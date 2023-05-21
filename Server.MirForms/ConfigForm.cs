using System.Net;
using System.Text.RegularExpressions;

namespace Server
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();

            VPathTextBox.Text = Settings.VersionPath;
            VersionCheckBox.Checked = Settings.CheckVersion;
            RelogDelayTextBox.Text = Settings.RelogDelay.ToString();

            IPAddressTextBox.Text = Settings.IPAddress;
            PortTextBox.Text = Settings.Port.ToString();
            TimeOutTextBox.Text = Settings.TimeOut.ToString();
            MaxUserTextBox.Text = Settings.MaxUser.ToString();

            StartHTTPCheckBox.Checked = Settings.StartHTTPService;
            HTTPIPAddressTextBox.Text = Settings.HTTPIPAddress;
            HTTPTrustedIPAddressTextBox.Text = Settings.HTTPTrustedIPAddress;

            AccountCheckBox.Checked = Settings.AllowNewAccount;
            PasswordCheckBox.Checked = Settings.AllowChangePassword;
            LoginCheckBox.Checked = Settings.AllowLogin;
            NCharacterCheckBox.Checked = Settings.AllowNewCharacter;
            DCharacterCheckBox.Checked = Settings.AllowDeleteCharacter;
            StartGameCheckBox.Checked = Settings.AllowStartGame;
            AllowAssassinCheckBox.Checked = Settings.AllowCreateAssassin;
            AllowArcherCheckBox.Checked = Settings.AllowCreateArcher;
            Resolution_textbox.Text = Settings.AllowedResolution.ToString();

            SafeZoneBorderCheckBox.Checked = Settings.SafeZoneBorder;
            SafeZoneHealingCheckBox.Checked = Settings.SafeZoneHealing;
            gameMasterEffect_CheckBox.Checked = Settings.GameMasterEffect;
            lineMessageTimeTextBox.Text = Settings.LineMessageTimer.ToString();

            SaveDelayTextBox.Text = Settings.SaveDelay.ToString();

            ServerVersionLabel.Text = Application.ProductVersion;
            DBVersionLabel.Text = MirEnvir.Envir.LoadVersion.ToString() + ((MirEnvir.Envir.LoadVersion < MirEnvir.Envir.Version) ? " (Update needed)" : "");
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Save();
            Settings.LoadVersion();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        public void Save()
        {
            // 将路径文本框中的文本设置为版本路径
            Settings.VersionPath = VPathTextBox.Text;
            // 将版本勾选框的值设置为是否检查版本
            Settings.CheckVersion = VersionCheckBox.Checked;
            Settings.CheckVersion = VersionCheckBox.Checked;

            IPAddress tempIP;
            // 如果能够解析IP地址文本框中的内容，就将该值设置为服务器IP地址，该值作为字符串存储
            if (IPAddress.TryParse(IPAddressTextBox.Text, out tempIP))
                Settings.IPAddress = tempIP.ToString();

            // 将是否开启HTTP服务勾选框的值保存为设置对象中的相应属性值
            Settings.StartHTTPService = StartHTTPCheckBox.Checked;
            // 查询HTTP IP地址文本框中的值是否能够正确解析，如果能，则将该值赋给设置对象的相应属性值
            if (tryParseHttp())
                Settings.HTTPIPAddress = HTTPIPAddressTextBox.Text.ToString();
            // 同理，查询可信任HTTP IP地址文本框中的值是否能够正确解析，如果能，则将该值赋给设置对象的相应属性值
            if (tryParseTrustedHttp())
                Settings.HTTPTrustedIPAddress = HTTPTrustedIPAddressTextBox.Text.ToString();

            ushort tempshort;
            int tempint;

            // 如果能够解析端口号文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (ushort.TryParse(PortTextBox.Text, out tempshort))
                Settings.Port = tempshort;

            // 如果能够解析超时时间文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (ushort.TryParse(TimeOutTextBox.Text, out tempshort))
                Settings.TimeOut = tempshort;

            // 如果能够解析最大用户数文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (ushort.TryParse(MaxUserTextBox.Text, out tempshort))
                Settings.MaxUser = tempshort;

            // 如果能够解析重新登录延迟时间文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (ushort.TryParse(RelogDelayTextBox.Text, out tempshort))
                Settings.RelogDelay = tempshort;

            // 如果能够解析自动保存延迟时间文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (ushort.TryParse(SaveDelayTextBox.Text, out tempshort))
                Settings.SaveDelay = tempshort;

            // 将是否允许创建新账户勾选框的值保存到设置对象中的相应属性值
            Settings.AllowNewAccount = AccountCheckBox.Checked;
            // 将是否允许修改密码勾选框的值保存到设置对象中的相应属性值
            Settings.AllowChangePassword = PasswordCheckBox.Checked;
            // 将是否允许登录勾选框的值保存到设置对象中的相应属性值
            Settings.AllowLogin = LoginCheckBox.Checked;
            // 将是否允许创建新角色勾选框的值保存到设置对象中的相应属性值
            Settings.AllowNewCharacter = NCharacterCheckBox.Checked;
            // 将是否允许删除角色勾选框的值保存到设置对象中的相应属性值
            Settings.AllowDeleteCharacter = DCharacterCheckBox.Checked;
            // 将是否允许开始游戏勾选框的值保存到设置对象中的相应属性值
            Settings.AllowStartGame = StartGameCheckBox.Checked;
            // 将是否允许创建刺客勾选框的值保存到设置对象中的相应属性值
            Settings.AllowCreateAssassin = AllowAssassinCheckBox.Checked;
            // 将是否允许创建弓箭手勾选框的值保存到设置对象中的相应属性值
            Settings.AllowCreateArcher = AllowArcherCheckBox.Checked;

            // 如果能够解析分辨率文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (int.TryParse(Resolution_textbox.Text, out tempint))
                Settings.AllowedResolution = tempint;

            // 将是否开启安全区域边界勾选框的值保存到设置对象中的相应属性值
            Settings.SafeZoneBorder = SafeZoneBorderCheckBox.Checked;
            // 将是否开启安全区域治疗效果勾选框的值保存到设置对象中的相应属性值
            Settings.SafeZoneHealing = SafeZoneHealingCheckBox.Checked;
            // 将是否开启GM效果勾选框的值保存到设置对象中的相应属性值
            Settings.GameMasterEffect = gameMasterEffect_CheckBox.Checked;
            // 如果能够解析行消息时间文本框中的内容，就将该值保存到设置对象中的相应属性值
            if (int.TryParse(lineMessageTimeTextBox.Text, out tempint))
                Settings.LineMessageTimer = tempint;
        }
    

        private void IPAddressCheck(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            IPAddress temp;

            ActiveControl.BackColor = !IPAddress.TryParse(ActiveControl.Text, out temp) ? Color.Red : SystemColors.Window;
        }

        private void CheckUShort(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            ushort temp;

            ActiveControl.BackColor = !ushort.TryParse(ActiveControl.Text, out temp) ? Color.Red : SystemColors.Window;
        }

        private void VPathBrowseButton_Click(object sender, EventArgs e)
        {
            if (VPathDialog.ShowDialog() == DialogResult.OK)
            {
                VPathTextBox.Text = string.Join(",", VPathDialog.FileNames);
            }
        }

        private void Resolution_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            int temp;

            ActiveControl.BackColor = !int.TryParse(ActiveControl.Text, out temp) ? Color.Red : SystemColors.Window;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void SafeZoneBorderCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SafeZoneHealingCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HTTPIPAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ActiveControl.BackColor = !tryParseHttp() ? Color.Red : SystemColors.Window;
        }


        private void HTTPTrustedIPAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            ActiveControl.BackColor = !tryParseTrustedHttp() ? Color.Red : SystemColors.Window;
        }

        bool tryParseHttp()
        {
            if ((HTTPIPAddressTextBox.Text.StartsWith("http://") || HTTPIPAddressTextBox.Text.StartsWith("https://")) && HTTPIPAddressTextBox.Text.EndsWith("/"))
            {
                return true;
            }
            return false;
        }

        bool tryParseTrustedHttp()
        {
            string pattern = @"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}";
            return Regex.IsMatch(HTTPTrustedIPAddressTextBox.Text, pattern);
        }

        private void StartHTTPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.StartHTTPService = StartHTTPCheckBox.Checked;
        }

        private void VersionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
