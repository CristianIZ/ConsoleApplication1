using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using Microsoft.QueryStringDotNET;
using NotificationsExtensions.Toasts;
using Windows.UI.Notifications;

namespace WFAH4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string title = "titulo";
            string content = "contenido";
            string logo = "Assets/fb.png";
            string image = "Assets/satya.jpg";

            ToastVisual visual = new ToastVisual()
            {
                TitleText = new ToastText() { Text = title },
                BodyTextLine1 = new ToastText() { Text = content },
                AppLogoOverride = new ToastAppLogo() { Source = new ToastImageSource(logo), Crop = ToastImageCrop.Circle },
                InlineImages = { new ToastImage() { Source = new ToastImageSource(image) } }
            };

            ToastActionsCustom action = new ToastActionsCustom()
            {
                Inputs = { new ToastTextBox("txt") { PlaceholderContent = "comment here" } },
                Buttons = { new ToastButton("Reply", new QueryString() { "Action", "Reply" }.ToString()) }
            };

            ToastContent Content = new ToastContent() { Visual = visual, Actions = action };
            ToastNotification notification = new ToastNotification();
            ToastNotificationManager.CreateToastNotifier().Show(notification);
        }
    }
}
