namespace LeonardoAndradeExamenProgresoalfanumericos.Views;

public partial class LAConteoc : ContentPage
{
	public LAConteoc()
	{
		InitializeComponent();
	}


	private void ClickGenerar(object sender, EventArgs e)
	{
		string input= inputEntry.Text;
		int nums = ContarNums(input);
		int letras =ContarLetras(input);
		int vocales= ContarVocales(input);
		int mayusculas = ContarMayusculas(input);
		int minusculas = ContarMinusculas(input);
		int total= input.Length;

		nums.Text = $"Numeros: {nums}";
		letras.Text = $"Letras: {letras}";
		vocales.Text = $"Vocales: {vocales}";
		mayusculas.Text= $"Mayusculas: {mayusculas}";
		minusculas.Text= $"Minusculas: {minusculas}";
		total.Text = $"Total: {total}";


	}


	private void LimpioClick(object sender, EventArgs e)
	{
		inputEntry.Text = string.Empty;
		nums.Text = string.Empty;
		letras.Text= string.Empty;
		vocales.Text = string.Empty;	
		mayusculas.Text = string.Empty;
		minusculas.Text =string.Empty;
		total.Text=string.Empty;



	}

	private int ContarNums(string input)
	{
		int contadorNumeros = 0;

		foreach (char caracter in input) { 
		
				if (char.IsDigit(caracter))
			{
				contadorNumeros++;
			}
				
				
				}
		return contadorNumeros;
	}

	private int ContarLetras(string input)
	{
		int contadorLetras = 0;
		foreach (char caracter in input)
		{
			if (char.IsLetter(caracter)) {
			contadorLetras++;
			}
		}
		return contadorLetras;
	}



	private int ContarVocales(string input)
	{
		int contadorVocales = 0;
		foreach(char caracter in input)
		{
			if("AEIOUaeiou".IndexOf(input) >= 0)
			{
				contadorVocales++;
			}
		}
		return contadorVocales;
	}

	private int ContarMayusculas(string input)
	{
		int contadorMayusculas = 0;

		foreach (char caracter in input)
		{
			if(char.IsUpper(caracter))
			{
				contadorMayusculas++;
			}
		}
		return contadorMayusculas;
	}
	private int ContarMinusculas(string input)
	{
		int contadorMinusculas = 0;

		foreach (char caracter in input)
		{
			if (char.IsLower(caracter))
			{
				contadorMinusculas++;
			}
		}
		return contadorMinusculas;
	}


    }