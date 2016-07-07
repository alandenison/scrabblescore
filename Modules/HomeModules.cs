using Nancy;
using ScrabbleScores.Objects;

namespace ScrabbleScores
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=> View ["index.cshtml"];

      Get["/get_score"]=_=> {
      Scores scores = new Scores (Request.Query["wordInput"]);
      int newScore = scores.CalculateScore();
      return View ["index.cshtml", newScore];
    };
    }
  }
}
