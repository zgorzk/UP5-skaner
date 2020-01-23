using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;

namespace SkanerPichetaKinastowski
{

    public partial class Form1 : Form
    {
        const string WIA_SCAN_COLOR_MODE = "6146";
        const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
        const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
        const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
        const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
        const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
        const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
        const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
        const string WIA_SCAN_CONTRAST_PERCENTS = "6155";

        DeviceManager deviceManager;
        DeviceInfo firstScannerAvailable;
        Device device;
        Item scannerItem;
        string path = @"C:\Users\lab\source\repos\SkanerPichetaKinastowski\SkanerPichetaKinastowski\scan.jpeg";


        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            deviceManager = new DeviceManager();
            firstScannerAvailable = null;

            for(int i=1; i <= deviceManager.DeviceInfos.Count; i++)
            {

                if(deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                continue;

                firstScannerAvailable = deviceManager.DeviceInfos[i];
                device = firstScannerAvailable.Connect();
                connectedLabel.Text = "Connected to: " + firstScannerAvailable.Properties["Name"].get_Value();
                scannerItem = device.Items[1];

                break;
            }
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, Int32.Parse(dpiTextBox.Text));
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, Int32.Parse(dpiTextBox.Text));

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, 0);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, 0);

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, Int32.Parse(WidthTextBox.Text));
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, Int32.Parse(heightTextBox.Text));

            SetWIAProperty(scannerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, 0);
            SetWIAProperty(scannerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, 0);

            if (colorModeComboBox.Text == "Color")
            {
                SetWIAProperty(scannerItem.Properties, WIA_SCAN_COLOR_MODE, 1);
            }
            if (colorModeComboBox.Text == "Grayscale")
            {
                SetWIAProperty(scannerItem.Properties, WIA_SCAN_COLOR_MODE, 2);
            }
   
          
            var imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Save image !
            imageFile.SaveFile(path);

            scannedImageBox.Image = Image.FromFile(@"C:\Users\lab\source\repos\SkanerPichetaKinastowski\SkanerPichetaKinastowski\scan.jpeg");
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private void scannedImageBox_Click(object sender, EventArgs e)
        {

        }
    }
}
