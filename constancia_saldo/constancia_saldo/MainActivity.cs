using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace constancia_saldo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {


		TextView saldo;
		Button boleto;
		Button cargar;
		EditText montoarecargar;


		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

			saldo = FindViewById<TextView>(Resource.Id.saldo);
			boleto = FindViewById<Button>(Resource.Id.boleto);
			cargar = FindViewById<Button>(Resource.Id.cargar);
			montoarecargar = FindViewById<EditText>(Resource.Id.montoarecargar);
				
			cargar.Click += carga;
			boleto.Click += pasaje;


			string saldos = this.Intent.GetStringExtra("monto");

        }
		void carga (object sender, EventArgs e)
		{
			int numero1;
			int numero2;
			int pasaje;


			numero1 = Convert.ToInt32(saldo.Text);
			numero2 = Convert.ToInt32(montoarecargar.Text);

			pasaje = sumar(numero1, numero2);

			saldo.Text = Convert.ToString(pasaje);
		}

		private int sumar(int numero1, int numero2)
		{
			int resultado;
			resultado = numero1 + numero2;
			return resultado;
		}


		private int restar(int numero1,int numero2)
		{
			int resultado;
			resultado = numero1 - numero2;
			return resultado;
		}

		void pasaje(object sender, EventArgs e)
		{
			int numero1;
			int numero2;
			int pasaje;


			numero1 = Convert.ToInt32(saldo.Text);
			numero2 = 23;

			pasaje = restar(numero1, numero2);

			saldo.Text = Convert.ToString(pasaje);

		}
    }
}