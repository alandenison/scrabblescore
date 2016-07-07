using System;
using System.Collections.Generic;

namespace ScrabbleScores.Objects
{
  public class Scores
  {
    private char[] one = {'A','E', 'I', 'O','U', 'L', 'N', 'R', 'S', 'T'};
    private char[] two = {'D', 'G'};
    private char[] three = {'B', 'C', 'M', 'P'};
    private char[] four = {'F', 'H', 'V', 'W', 'Y'};
    private char[] five = {'K'};
    private char[] eight = {'J', 'K'};
    private char[] ten = {'Q', 'Z'};
    private char[] _wordInput;
    private int Score = 0;
    public Scores(string word)
    {
     this._wordInput = word.ToCharArray();

    }

    public int CalculateScore()
    {
      for(int i = 0; i<_wordInput.Length; i++){

          if(Array.Exists(one, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score +=1;
          }
          else if (Array.Exists(two, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score +=2;
          }
          else if(Array.Exists(three, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score += 3;
          }
          else if (Array.Exists(four, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score += 4;
          }
          else if (Array.Exists(five, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score += 5;
          }
          else if (Array.Exists(eight, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score += 8;
          }
          else if (Array.Exists(ten, element => element == (Char.ToUpper(_wordInput[i]))))
          {
            Score += 10;
          }
        else
        {
          Score +=0;
        }
    }
    return Score;

}

  }
}
