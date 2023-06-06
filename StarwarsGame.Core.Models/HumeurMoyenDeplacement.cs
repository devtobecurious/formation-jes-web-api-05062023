namespace StarwarsGame.Core.Models
{
    public class HumeurMoyenDeplacement
    {
        private static Random __random = new Random();
        private static Dictionary<Mood, IMoyenDeplacement> __dico = new()
        {
            { Mood.Happy, new Leia() },
            { Mood.Angry, new MotoJet(mess => { }) },
            { Mood.Sad, new MotoJet(mess => { }) },
        };

        public IMoyenDeplacement? Get()
        {
            // IMoyenDeplacement? deplacement = null;

            int humeurEntiere = __random.Next(0, 3);

            Mood mood = (Mood)humeurEntiere;

            return __dico[mood];
            //switch (mood)
            //{
            //    case Mood.Happy:
            //        deplacement = new Leia();
            //        break;
            //    case Mood.Angry:
            //        deplacement = new MotoJet(mess => { });
            //        break;
            //    case Mood.Sad:
            //        deplacement = new MotoJet(mess => { });
            //        break;
            //    default:
            //        break;
            //}

            // return deplacement;
        }
    }
}
