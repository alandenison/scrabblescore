using System.Collections.Generic;
using Xunit;
using ScrabbleScores.Objects;

namespace Scrabble
{
  public class ScrabbleScoresTest
  {
    [Fact]
    public void Score_ForA_ReturnNumber()
    {
    Scores scores = new Scores("aei");
    int newScore = scores.CalculateScore();
    Assert.Equal(3, newScore );
    }
    [Fact]
    public void Score_ForD_ReturnNumber()
    {
    Scores scores = new Scores("d");
    int newScore = scores.CalculateScore();
    Assert.Equal(2, newScore );
    }
    [Fact]
    public void Score_ForB_ReturnNumber()
    {
    Scores scores = new Scores("b");
    int newScore = scores.CalculateScore();
    Assert.Equal(3, newScore );
    }
    [Fact]
    public void Score_ForWord_ReturnNumber()
    {
    Scores scores = new Scores("Apple");
    int newScore = scores.CalculateScore();
    Assert.Equal(9, newScore );
    }
  }
}
