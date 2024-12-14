
string hello = "we are the champions? ";

int stringLenght = hello.Length;
//string trimmedString = hello.Trim(); //sulud on siin nagu tegusõna, et tee midagi
// teine variant on sama asi teha järgnevalt:
hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');//siin asendan väikese h tähe suurega. 
//kindlam on kasutada toUpper või lower sest sõnad võivad muutuda
//replacei võib kasutada nii palju kui vaja

firstLetter = hello[0];

Console.WriteLine(firstLetter);

Console.WriteLine(hello);



//int wordCounter = 1;


//for(int i = 0; i < hello.Length; i++)
{

   // if (char.IsWhiteSpace(hello[i]))
    {
      //  wordCounter++;
    }
   // if (hello[i] ==  ' ')
    //{
     //   wordCounter++;
    //}

    //Console.WriteLine($"{i} symbol in string: {hello[i]}");
    //kommentaari pandud variant 1 sama asja jaoks
}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");
//Console.WriteLine(hello.Length); //esimese puhul peab seal olema trimString.Length
//teise puhul on hello.Lenthg

// tähe asukoht on alati length -1. Hello- tähti on 5, aga asukohad hakkavad alates 0st.

