using System.Threading;
using System.Windows;

namespace Launcher
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App
    {
        private static Mutex _instanceMutex;
        protected override void OnStartup(StartupEventArgs e)
        {
            _instanceMutex = new Mutex(true, "F37E84CB-D76A-49B1-A1AC-80870903087B", out var createdNew);
            if (!createdNew)
            {
                MessageBox.Show("己经启动", "是否重新开始", MessageBoxButton.OK, MessageBoxImage.Warning);
                _instanceMutex = null;
                Current.Shutdown();
                return;
            }
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _instanceMutex?.ReleaseMutex();
            base.OnExit(e);
        }
    }
}
