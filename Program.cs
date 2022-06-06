static int[] RandomArray(){
    Random rand=new Random();
    int[]arr=new int[10];
    int max=0;
    int min=25;
    int sum=0;
    for (int i=0;i<arr.Length;i++){
        arr[i]=rand.Next(5,25);
        if (arr[i]>max){
            max=arr[i];
        }
        if (arr[i]<min){
            min=arr[i];
        }
        sum+=arr[i];
    }
    Console.WriteLine("Max="+max+" Min="+min);
    Console.WriteLine("Sum="+sum);
    return arr;
}
RandomArray();

static string TossCoin(){
    Random rand=new Random();
    Console.WriteLine("Tossing a coin");
    string result="";
    if(rand.Next(1,3)==1){
        result="Heads";
    }
    else{
        result="Tails";
    }
    Console.WriteLine(result);
    return result;
}
TossCoin();


static List<string> Names(){
    List<string> nameList=new List<string>();
    nameList.Add("Todd");
    nameList.Add("Tiffany");
    nameList.Add("Charlie");
    nameList.Add("Geneva");
    nameList.Add("Sydney");
    for(int i=0;i<nameList.Count;i++){
        if(nameList[i].Length<6){
            nameList.RemoveAt(i);
            i--;
        }
    }
return nameList;
}
List<string> allNames=Names();
foreach(var name in allNames){
    System.Console.WriteLine(name);
}