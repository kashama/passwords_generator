namespace generateur_de_mot_de_passe
{
    internal class Program
    {
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
