namespace generateur_de_mot_de_passe
{
    internal class Program
    {

        static int DemanderNombrePositifNoNul(string question)
        {
            //int nombrePositif = DemanderNombreEntre()
            //if (!nombrePositif == null && nombrePositif > 0 )
            //{
            //    return nombrePositif;
            //}
            //Console.WriteLine("Erreur: Le nombre ne doit pas etre negatif ou nul.")
            return DemanderNombreEntre(question, 1, int.MaxValue);// la fonction recursive c'est celle qui fait appelle à elle-meme 
        }
        static int DemanderNombreEntre(string question, int min, int max)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);
                if (nombre >= min && nombre <= max)
                {
                    return nombre;
                }
                Console.WriteLine("Erreur: Le nombre doit etre compris entre" + min + " et " + max)
            }
        }
        static int DemanderNombre(string question)
        {
            while (true) 
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int  reponseInt = int.Parse(reponse);
                    return reponseInt;

                }
                catch
                {
                    Console.WriteLine("Erreur: Vous devez entrer un nombre.");
                }
                
            }
            
        }
        static void Main(string[] args)
        {
            int longeurMotDePasse= DemanderNombre("Longeur de mot de passe:");
        }
    }
}
