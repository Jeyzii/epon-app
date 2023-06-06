using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace Epon
{
    
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText editText1, editText2;
        Button btn1, btn2, btn3;
        TextView savingsView, targetView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            editText1 = FindViewById<EditText>(Resource.Id.editText1);
            editText2 = FindViewById<EditText>(Resource.Id.editText2);
            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn3 = FindViewById<Button>(Resource.Id.btn3);
            savingsView = FindViewById<TextView>(Resource.Id.savingsView);
            targetView = FindViewById<TextView>(Resource.Id.targetView);
            btn1.Click += btn1_Click;
            btn2.Click += btn2_Click;
            btn3.Click += btn3_Click;

          
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(editText1.Text);
                double b = Double.Parse(savingsView.Text);

                savingsView.Text = (a + b).ToString();
                Toast.MakeText(this, "Savings added!", ToastLength.Short).Show();
               
            }
            catch (Exception)
            {
                Toast.MakeText(this, "'Please input value first!", ToastLength.Short).Show();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(editText1.Text);
                double b = Double.Parse(savingsView.Text);
            
            savingsView.Text = ((a - b) *-1).ToString();
            Toast.MakeText(this, "Savings deducted!", ToastLength.Short).Show();
        }
            catch (Exception)
            {
                Toast.MakeText(this, "'Please input value first!", ToastLength.Short).Show();
            }
        }
        
        private void btn3_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "target money!", ToastLength.Short).Show();
            targetView.Text = editText2.Text;
            editText2.Text = "";
        }

    }
}