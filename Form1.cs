using System.Windows.Forms;
using TrueConfVideoSDKLibrary;

namespace NuGetSampleTrueConfVideoSDK
{
    public partial class Form1 : Form
    {
        VideoSDK sdk;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitControls()
        {
            clearErrorMsg();
            buttonConnectToTCS.Enabled = false;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = false;
            buttonSendChatMessage.Enabled = false;
            labelStatus.Text = "Unknown";
            labelStateColor.BackColor = Color.Gray;
            buttonCall.ImageIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //
        }

        private void WebSocketConnectionStatusChange(object source, WebSocketConnectionStatus status)
        {
            buttonConnectToTCS.Enabled = (status == WebSocketConnectionStatus.Connected);
        }

        private void OnStateChange(object source, AppStateChangedEventArgs appStateChangedEventArgs)
        {
            labelStatus.Text = AppStates.GetHint(appStateChangedEventArgs.NewState);

            buttonLogin.Enabled = (appStateChangedEventArgs.NewState == 2);
            buttonLogout.Enabled = (appStateChangedEventArgs.NewState == 3);
            buttonSendChatMessage.Enabled = (appStateChangedEventArgs.NewState == 3) || (appStateChangedEventArgs.NewState == 4) || (appStateChangedEventArgs.NewState == 5);

            switch (appStateChangedEventArgs.NewState)
            {
                case 2:
                    labelStateColor.BackColor = Color.Red;
                    buttonCall.ImageIndex = 0;
                    break;
                case 3:
                    labelStateColor.BackColor = Color.Green;
                    buttonCall.ImageIndex = 1;
                    break;
                case 4:
                    labelStateColor.BackColor = Color.Yellow;
                    buttonCall.ImageIndex = 3;
                    break;
                case 5:
                    labelStateColor.BackColor = Color.Yellow;
                    buttonCall.ImageIndex = 3;
                    break;
                default:
                    labelStateColor.BackColor = Color.Gray;
                    buttonCall.ImageIndex = 0;
                    break;
            }
        }

        void OnEvent(object source, string response)
        {
            textBoxLog.AppendText("OnEvent: " + response + "\r\n");
        }

        // the notification about an incoming video call (call) or about an invitation to a group conference
        void OnInviteReceived(object source, string response)
        {
            textBoxLog.AppendText("OnInviteReceived: " + response + "\r\n");
            if (checkBoxAutoAccept.Checked)
                sdk.Methods.accept();
            else
                sdk.Methods.reject();
        }

        void OnMethod(object source, string response)
        {
            textBoxLog.AppendText("OnMethod: " + response + "\r\n");
        }
        void OnError(object source, string message)
        {
            labelError.Text = message;
            textBoxLog.AppendText("OnError: " + message + "\r\n");
        }

        private void clearErrorMsg()
        {
            labelError.Text = "";
        }

        private void beforeNewSession()
        {
            InitControls();

            sdk?.CloseSession();

            sdk = new VideoSDK(false);

            sdk.OnWebSocketConnectionStatusChanged += WebSocketConnectionStatusChange;
            sdk.OnAppStateChanged += OnStateChange;
            sdk.Events.On_incomingChatMessage += OnEvent;
            // the notification about an incoming video call (call) or about an invitation to a group conference
            sdk.Events.On_inviteReceived += OnInviteReceived;
            sdk.Methods.OnMethodResponse += OnMethod;
            sdk.OnError += OnError;
        }

        private void buttonOpenSession_Click(object sender, EventArgs e)
        {
            beforeNewSession();

            clearErrorMsg();

            try
            {
                buttonOpenSession.Enabled = false;
                sdk.OpenSession(textBoxVideoSDK_IP.Text, Int32.Parse(textBoxVideoSDK_Port.Text), textBoxVideoSDK_PIN.Text);
            }
            catch (VideoSDKException ex)
            {
                labelError.Text = ex.Message;
                textBoxLog.AppendText("OpenSession error: " + ex.Message + "\r\n");
            }
            buttonOpenSession.Enabled = true;
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            if (sdk.AppState == 3)
            {
                sdk.Methods.call(textBoxCallID.Text);
            }
            else if (sdk.AppState == 4 || sdk.AppState == 5)
            {
                sdk.Methods.hangUp();
            }
        }

        private void buttonConnectToTCS_Click(object sender, EventArgs e)
        {
            sdk.Methods.connectToServer(textBoxTrueConfServerAddress.Text);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sdk.Methods.login(textBoxTrueConfID.Text, textBoxPassword.Text);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            sdk.Methods.logout();
        }

        private void buttonSendChatMessage_Click(object sender, EventArgs e)
        {
            sdk.Methods.sendMessage(textBoxCallID.Text, "Hi!");
        }
    }
}