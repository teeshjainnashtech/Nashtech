namespace Problem1
{
    class Problem1 {         
        static void Main(string[] args)
        {
            string? input = System.Console.ReadLine();
            //Converting the complete string into Lowercase
            input = input.ToLower();
            //First Character should always be in Upper case
            string answer = input[0].ToString().ToUpper();

            int length = input.Length;
            bool isSpace = false;
            for(int i=1;i<length;i++){
                isSpace = input[i] == ' '? true : false;
                if(isSpace){
                    i++;
                    answer+= input[i].ToString().ToUpper();
                }
                else{
                    answer+= input[i];
                }
            }

            System.Console.WriteLine(answer);

        }
    }
}
