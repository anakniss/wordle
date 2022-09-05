// See https://aka.ms/new-console-template for more information

int i = 0;
int b = 0;
string[] words = { "About", "Alert", "Argue", "Beach", "Above", "Alike", "Arise", "Began"};
int randomIndex = Random.Shared.Next(0, words.Length);
string word = words[randomIndex];

Console.WriteLine("Welcome! Enter a word with 5 letters to start");

while (true)
{
    string userWord = Console.ReadLine();
    
    if(userWord.Length == 5) {

        for (b = 0; b < userWord.Length; b++)
        {
            bool exist = false;
            bool correctPosition = false;

            
            for (i = 0; i < word.Length; i++)
            {
                if (word[i] == userWord[b]) //verifica se as letras são iguais
                {
                    if (i == b)
                    {
                        Console.WriteLine($"A letra {userWord[b]} está contida e também na posição correta");

                        correctPosition = true;
                    }

                    exist = true;
                    
                }
            }

            if (exist == true && correctPosition != true)
            {
                Console.WriteLine($"A letra {userWord[b]} está contida mas não está na posição correta");
            }

            if (exist == false)
            {
                Console.WriteLine($"A letra {userWord[b]} não está contida");
            }
        }
    }

    else
    {
        Console.WriteLine("Enter a word with 5 letters");
    }
}





