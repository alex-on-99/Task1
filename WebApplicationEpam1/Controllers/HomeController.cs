using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationEpam1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>()
            {
                new Article("How much sugar can I eat?", new DateTime(2018,12,12,11,22,0),"World Health Organization recommends WHO calls on countries to reduce sugar intake by adults and children to reduce sugar intake to 10% of the total energy value of the diet. The WHO says that this will reduce the risk of overweight and tooth decay. Experts say that reducing sugar intake to 5% of daily calories will bring additional health benefits. Therefore, a not very active thirty-year-old man with a height of 180 cm and a weight of 70 kg is recommended to eat no more than 60 g of sugar per day. Now, according to statistics, the average Russian consumes 40 kg of sugar per year, which is about 109 g per day, by the population of the Russian Federation."),
                new Article("How many grams of protein you need to consume per day to be healthy", new DateTime(2019,2,7,10,22,0),"The amount of protein is of great importance not only for building muscle mass, but also for overall health. Find out why protein is so important and how many grams you need to include in your diet for you. A protein consists of amino acid molecules that are linked to each other by a peptide bond. 20 amino acids are involved in protein synthesis in the body, eight of them(for an adult) are indispensable. This means that the body cannot synthesize these amino acids, they come only with food. Proteins are used for metabolism in cells, the production of enzymes, hormones, immune cells and antibodies, and other compounds that provide all the important functions of the body. Even the leanest diet includes some protein. The question is whether it is enough for health, good physical fitness and quality work of all systems and organs."),
                new Article("Where to get simple and complex carbohydrates?", new DateTime(2019,8,22,2,10,0),"Simple carbohydrates are found in foods such as fruits, dairy products, sugar (pure carbohydrates), and honey. Complex carbohydrates are found in cereal products (cereals, hard pasta, bread, flour), potatoes, corn, and legumes. Despite the fact that flour belongs to complex carbohydrates, processed (refined) products from it, such as baked goods, buns, etc., belong to simple carbohydrates. In addition to simple and complex carbohydrates, there are also dietary fibers (fiber) that have such a complex structure that they are not digested by our body. Dietary fiber should be an integral part of your diet, as it ensures the functioning of the digestive system."),
            };

            ViewData["Articles"] = articles;
            return View();
        }

        public ActionResult Guest()
        {
            ViewData["Reviews"] = ReviewsList.reviews;
            return View();
        }

        [HttpPost]
        public ActionResult Guest(FormCollection form)
        {
            Review review = new Review(form["Name"], form["Text"]);
            ReviewsList.reviews.Insert(0,review);
            ViewData["Reviews"] = ReviewsList.reviews;
            return View();
        }

        public ActionResult Profile(FormCollection form)
        {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                ViewData["Name"] = form["nameQuestion"];
                ViewData["Age"] = form["ageQuestion"];
                ViewData["Dish"] = form["dishQuestion"];
                ViewData["Fruit"] = form["fruit"];
                ViewData["Vegetable"] = form["vegetable"];
                List<string> badHabits = new List<string>();
                if (form["badHabit1"] != null)
                    badHabits.Add(form["badHabit1"]);
                if (form["badHabit2"] != null)
                    badHabits.Add(form["badHabit2"]);
                if (form["badHabit3"] != null)
                    badHabits.Add(form["badHabit3"]);
                if (badHabits.Count > 0)
                {
                    ViewData["BadHabits"] = badHabits;
                }
                return View("ProfileReady");
            }
            return View();
        }
    }
}