using SpartanExtensions.Strings;
using SpartanSettings;
namespace SpartanEmail
{
    public class Config
    {
        private static ISetting _setting;
        public bool Enabled { get; set; }
        public string Key { get; set; }
        public string EmailSupport { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        public Config()
        {
            SetModuleSettings();
        }

        public void SetModuleSettings()
        {
            _setting = new Setting();
            var cPath = _setting.CreateModuleSetting("email");
            if (!string.IsNullOrEmpty(cPath))
            {
                var cTemp = cPath.LoadAsJsonType();
                Enabled = cTemp.ContainsKey("Enabled") ? (bool)cTemp.GetValue("Enabled") : false;
                Key = cTemp.ContainsKey("Key") ? (string)cTemp.GetValue("Key") : "";
                EmailSupport = cTemp.ContainsKey("EmailSupport") ? (string)cTemp.GetValue("EmailSupport") : "";
                FromName = cTemp.ContainsKey("FromName") ? (string)cTemp.GetValue("FromName") : "";
                FromEmail = cTemp.ContainsKey("FromEmail") ? (string)cTemp.GetValue("FromEmail") : "";
                Subject = cTemp.ContainsKey("Subject") ? (string)cTemp.GetValue("Subject") : "";
            }
        }
    }
}
