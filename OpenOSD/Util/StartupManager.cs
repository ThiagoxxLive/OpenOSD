using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

public static class StartupManager
{
    private const string RUN_KEY = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
    public static void SetStartup(string appName, bool enable)
    {
        try
        {
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(RUN_KEY, true))
            {
                if (rk == null)
                {
                    MessageBox.Show("Não foi possível acessar o registro do Windows.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (enable)
                {
                    string exePath = Application.ExecutablePath;
                    rk.SetValue(appName, $"\"{exePath}\"");
                }
                else
                {
                    rk.DeleteValue(appName, false);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao modificar o registro de inicialização: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
  
    public static bool IsStartupEnabled(string appName)
    {
        try
        {
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(RUN_KEY, false))
            {
                if (rk == null)
                {
                    return false;
                }

                var value = rk.GetValue(appName) as string;

                if (string.IsNullOrEmpty(value))
                {
                    return false;
                }

                
                string exePath = Application.ExecutablePath;
                return value.Trim('"').Equals(exePath, StringComparison.OrdinalIgnoreCase);
            }
        }
        catch
        {
            return false;
        }
    }

    public static void SetStartupTask(string appName, bool enable)
    {
        try
        {
            using (TaskService ts = new TaskService())
            {
                if (enable)
                {                    
                    TaskDefinition td = ts.NewTask();
                    td.RegistrationInfo.Description = "Inicializa o " + appName + " com privilégios elevados";

                    td.Principal.RunLevel = TaskRunLevel.Highest;

                    td.Triggers.Add(new LogonTrigger());
                    td.Actions.Add(new ExecAction(Application.ExecutablePath, null, Application.StartupPath));

                    ts.RootFolder.RegisterTaskDefinition(appName, td);
                }
                else
                {
                    ts.RootFolder.DeleteTask(appName, false);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao configurar a tarefa agendada: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}