using Android.App;
using Android.Hardware.Camera2;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Java.Interop;
using System.Collections.Generic;

namespace CameraAPItest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private SurfaceView surfaceView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            surfaceView = FindViewById<SurfaceView>(Resource.Id.surfaceview_camera_capture);
            ImageReader imageReader = ImageReader.NewInstance(surfaceView.Width, surfaceView.Height, Android.Graphics.ImageFormatType.Raw12, 1);

            Surface surfacePreview = surfaceView.Holder.Surface;
            Surface imageSurface = imageReader.Surface;


            List<Surface> targets = new List<Surface>();
            targets.Add(surfacePreview);
            targets.Add(imageSurface);

            CameraDevice.
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}