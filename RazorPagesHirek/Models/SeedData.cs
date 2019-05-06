using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesHirek.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesHirekContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesHirekContext>>()))
            {
                // Look for any articles
                if (context.Article.Any())
                {
                    return;   // DB has been seeded
                }
                context.Article.AddRange(
                    new Article
                    {
                        Title = "The thing about owning a Tesla no one talks about — nightmarish repair delays",
                        ArticleText = "Craig Hedges was driving on the Stanford campus on Oct. 27, 2018, when a Toyota Corolla pulled out from a parking space and plowed into his 2016 Tesla Model S. Neither vehicle was moving very fast, but the Tesla sustained front fender and suspension damage and wasn't drivable. So the Burlingame resident had it towed a few days later to Chilton Auto Body in San Carlos, the nearest Tesla-approved body shop and the preferred shop of his insurer, Allstate. Nearly six months later, he says his Model S still hasn't been repaired."
                    },
                    new Article
                    {
                        Title = "Taylor Swift, iOS, and the Access Economy: Why the Normal Distribution is Vanishing",
                        ArticleText = "There’s a classic exercise that we often encounter in business school, or elsewhere in higher education: the professor proposes, “I have two tickets to the Taylor Swift concert this Saturday night. All of you should write down on a piece of paper the maximum amount they’d be willing to pay for these tickets, then turn them in, and we’ll look at the distribution of those prices.” The idea is that from there, a promoter should be able to determine the optimal price (or sets of prices) to charge in order to maximize their sales."
                    },
                    new Article
                    {
                        Title = "Biomarker for chronic fatigue syndrome identified",
                        ArticleText = "People suffering from a debilitating and often discounted disease known as chronic fatigue syndrome may soon have something they’ve been seeking for decades: scientific proof of their ailment. Researchers at the Stanford University School of Medicine have created a blood test that can flag the disease, which currently lacks a standard, reliable diagnostic test."
                    },
                    new Article
                    {
                        Title = "Autonomous robotic intracardiac catheter navigation using haptic vision",
                        ArticleText = "Although all minimally invasive procedures involve navigating from a small incision in the skin to the site of the intervention, it has not been previously demonstrated how this can be performed autonomously. To show that autonomous navigation is possible, we investigated it in the hardest place to do it—inside the beating heart. We created a robotic catheter that can navigate through the blood-filled heart using wall-following algorithms inspired by positively thigmotactic animals. The catheter uses haptic vision, a hybrid sense using imaging for both touch-based surface identification and force sensing, to accomplish wall following inside the blood-filled heart. Through in vivo animal experiments, we demonstrate that the performance of an autonomously controlled robotic catheter rivaled that of an experienced clinician. Autonomous navigation is a fundamental capability on which more sophisticated levels of autonomy can be built, e.g., to perform a procedure. Similar to the role of automation in a fighter aircraft, such capabilities can free the clinician to focus on the most critical aspects of the procedure while providing precise and repeatable tool motions independent of operator experience and fatigue."
                    },
                    new Article
                    {
                        Title = "A Mystery Frequency Disrupted Car Fobs in an Ohio City, and Now Residents Know Why",
                        ArticleText = "It sounded like something from an episode of “The X-Files”: Starting a few weeks ago, in a suburban neighborhood a few miles from a NASA research center in Ohio, garage door openers and car key fobs mysteriously stopped working. Garage door repair people, local ham radio enthusiasts and other volunteer investigators descended on the neighborhood with various meters.Everyone agreed that something powerful was interfering with the radio frequency that many fobs rely on, but no one could identify the source."
                    },
                    new Article
                    {
                        Title = "NASA announces funding for RIT professor to develop novel diffractive solar sails",
                        ArticleText = "Scientists have been floating designs for solar sails to propel spacecraft for decades, but a new approach being developed by a Rochester Institute of Technology professor could be the key to helping spacecraft photograph the poles of the sun for the first time. NASA announced it is providing RIT Professor Grover Swartzlander a Phase II award through its NASA Innovative Advanced Concepts(NIAC) program to explore the feasibility of diffractive solar sails over the next two years."
                    },
                    new Article
                    {
                        Title = "Engineers say Boeing pushed to limit safety testing in race to certify planes, including 737 MAX",
                        ArticleText = "In 2016, as Boeing raced to get the 737 MAX certified by the Federal Aviation Administration (FAA), a senior company engineer whose job was to act on behalf of the FAA balked at Boeing management demands for less stringent testing of the fire-suppression system around the jet’s new LEAP engines. That June he convened a meeting of all the certification engineers in his unit, who collectively agreed with his assessment.Management initially rejected their position, and only after another senior engineer from outside the MAX program intervened did managers finally agree to beef up the testing to a level the engineer could accept, according to two people familiar with the matter. But his insistence on a higher level of safety scrutiny cost Boeing time and money. Less than a month after his peers had backed him, Boeing abruptly removed him from the program even before conducting the testing he’d advocated."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
