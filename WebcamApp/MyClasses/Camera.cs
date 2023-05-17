﻿using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebcamApp.Properties;

namespace WebcamApp
{
    public class Camera {
        static FilterInfoCollection filterInfoCollection;
        static VideoCaptureDevice videoCaptureDevice;
        static private MainForm mainForm;
        static public Bitmap newFrame;

        static public void InitCameras(MainForm caller)
        {
            mainForm = caller;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
        }

        static private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (mainForm.mainCamera.Image != null) mainForm.mainCamera.Image.Dispose();
            newFrame = (Bitmap)eventArgs.Frame.Clone();
            mainForm.mainCamera.Image = newFrame;
            //mainForm.mainCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            // (Bitmap)eventArgs.Frame.Clone();
            //t++;
            //Console.WriteLine($"{t}");
        }
        static public void Start()
        {
            videoCaptureDevice.Start();
        }

        static public void Stop()
        {
            videoCaptureDevice.Stop();
        }

        static public bool IsRunning()
        {
            return videoCaptureDevice.IsRunning;
        }

        // Called when the settings form is loaded
        // fills the available camera combo box and selects the saved index
        static public void InitSettings(ComboBox cbo) 
        {
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbo.Items.Add(filterInfo.Name);
            }
            cbo.SelectedIndex = (int)Settings.Default["SelectedCameraIndex"];
        }
        static public void SetSizeMode(MainForm mainForm) {
            string savedSizeMode = Settings.Default["CameraSizeMode"].ToString();
            if (savedSizeMode == "Stretch Image")
            {
                mainForm.mainCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (savedSizeMode == "Center Image")
            {
                mainForm.mainCamera.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (savedSizeMode == "Zoom")
            {
                mainForm.mainCamera.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}