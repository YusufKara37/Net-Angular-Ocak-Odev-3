

#region 1️-)Koşullu ifadeler (if-else) ne işe yarar? Gerçek hayattan bir örnek verin.
    //85 üstü bir ortalaman varsa takdir alırsın(if)
    //yoksa alamazsın(elese)
#endregion

#region 2️-)Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı yazın.
    Console.WriteLine("lütfen bir sayı giriniz");
    int sayi=Convert.ToInt32(Console.ReadLine());
     if(sayi%2==0)
     {
        Console.WriteLine("girdiğiiz sayı çift");
     }
     else
     {
        Console.WriteLine("girdiğiniz sayı tek");
     }
#endregion

#region 3️-)Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın.

    int sayi2=Convert.ToInt32(Console.ReadLine());

    if(sayi2>0)
    {
        Console.WriteLine("pozitif");
    }
    else
    {
        Console.WriteLine ("negatif");
    }
    
#endregion