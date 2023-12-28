while (true)
{
    Console.Clear();
    static float obterpeso()
    {
        Console.WriteLine("digite tua peso");
        string? input = Console.ReadLine();
        return (float)Convert.ToDecimal(input);
    }

    static float obteraltura()
    {
        Console.WriteLine("digite tua altura");
        string? input = Console.ReadLine();
        return (float)Convert.ToDecimal(input);
    }

    float peso = obterpeso();
    float altura = obteraltura();
    Console.WriteLine("sua altura é: " + altura + "m e seu peso é: " + peso + "kg");
    float imc = peso / (altura * altura);
    Console.WriteLine("seu imc é: " + imc);

    if (imc <= 17)
    {
        Console.WriteLine("Você está muito abaixo do peso");
    }
    else if (imc >= 17.01 && imc <= 18.49)
    {
        Console.WriteLine("Você está abaixo do peso");
    }
    else if (imc >= 18.5 && imc <= 24.99)
    {
        Console.WriteLine("Você está no peso ideal");
    }
    else if (imc >= 25 && imc <= 29.99)
    {
        Console.WriteLine("Você está acima do peso");
    }
    else if (imc >= 30 && imc <= 34.99)
    {
        Console.WriteLine("Você está com obesidade I");
    }
    else if (imc >= 35 && imc <= 39.99)
    {
        Console.WriteLine("Você está com obesidade II (severa)");
    }
    else if (imc > 40)
    {
        Console.WriteLine("Você esta comObesidade III (mórbida)");
    }

        Console.ReadKey();
}
