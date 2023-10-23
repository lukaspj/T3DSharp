using T3DSharpFramework.Engine;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Functions;
using T3DSharpFramework.Interop;

namespace Modules.T3DSharpGame;

public class Main {
   [ScriptEntryPoint]
   public static void CSharpEntryFunction()
   {
      Global.SetConsoleString("Core::windowIcon", "data/icon.png");
      Global.SetConsoleString("Core::splashWindowImage", "data/splash.png");

      // Enable console logging, which creates the file console.log each time you run
      // the engine.
      Global.SetLogMode(6);

      // Disable script trace.
      Global.Trace(false);

      // Set the name of our application
      Global.SetConsoleString("appName", "Game");

      //-----------------------------------------------------------------------------
      // Load up scripts to initialise subsystems.
      ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
      ModuleDatabase.SetModuleExtension("module");
      ModuleDatabase.ScanModules("core", false);
      ModuleDatabase.LoadExplicit("CoreModule");
      if (!ModuleDatabase.LoadExplicit("CoreModule"))
         Global.Quit();

      // Display a splash window immediately to improve app responsiveness before
      // engine is initialized and main window created.
      if (Global.GetConsoleBool("Server::Dedicated") == false)
      {
         if (Global.GetConsoleString("platform") == "windows")
         {
            Global.DisplaySplashWindow(Global.GetConsoleString("Core::splashWindowImage"));
         }
      }
      else
      {
         Global.SetConsoleInt("Video::forceDisplayAdapter", -1);
      }

      //-----------------------------------------------------------------------------
      // Load any gameplay modules
      ModuleDatabase.ScanModules("data", false);
      ModuleDatabase.LoadGroup("Game");

      //Finally, initialize the client/server structure
      ModuleDatabase.LoadExplicit("Core_ClientServer");

      if (Global.IsFunction("loadStartup"))
      {
         Global.Call("loadStartup");
      }
      else
      {
         GuiCanvas Canvas = Sim.FindObject<GuiCanvas>("Canvas");
         //If nothing else set a main menu, try to do so now
         if (Canvas != null && Sim.FindObjectById<GuiControl>((uint)Canvas.GetContent()) != null)
         {
            Settings ProjectSettings = Sim.FindObject<Settings>("ProjectSettings");
            string mainMenuGUI = ProjectSettings?.Value("UI/mainMenuName");
            if (Global.IsObject(mainMenuGUI))
               Canvas.SetContent(Sim.FindObject<GuiControl>(mainMenuGUI));
         }
      }

      if (Global.GetConsoleBool("Server::Dedicated") == false && Global.GetConsoleString("platform") == "windows")
         Global.CloseSplashWindow();

      Global.Echo("Engine initialized...");
   }

   //-----------------------------------------------------------------------------
   // Called when the engine is shutting down.
   [ConsoleFunction]
   public static void onExit()
   {
      ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
      ModuleDatabase.UnloadExplicit("CoreModule");
      ModuleDatabase.UnloadGroup("Game");
   }
}
