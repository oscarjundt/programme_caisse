using System;
using System.Collections.Generic;
class md{
    static void Main(){
        List<int> nomb_enf = new List<int>();
        Console.Write("donner nombre adulte: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("donner nombre enfant: ");
        int b = int.Parse(Console.ReadLine());
        if(b>0){
            for(int i=0;i<b;i++){
                Console.Write("donner age enfant: ");
                int d = int.Parse(Console.ReadLine());
                nomb_enf.Add(d);
            }
        }
        affichage(a,b,nomb_enf);
        
    }
    public static void affichage(int x, int y, List<int> xy){
        int aa = 0;
        int ae = 0;
        for(int i2=0;i2<xy.Count;i2++){
            if(xy[i2]<=3){
                aa++;
            }
            if(xy[i2]>3){
                ae++;
            }
        }
        if(aa>0){
            int cdc = avec3(x,ae);
            Console.WriteLine(cdc+"€");
        }
        else{
            int cdc2 = sans3(x,y);
            Console.WriteLine(cdc2);
        }
    }
    public static int avec3(int ii2, int ii3){
        int argenf2 = 3;
        int argad = 6;
        int nott = 0;
        if(ii3!=0){
            for(int i4=1;i4<=ii3;i4++){
                argenf2=argenf2*i4;
            }
        }
        else{
            argenf2=0;
        }
        nott = argad*ii2;
        int cc = nott+argenf2;
        return cc;
    }
    public static int sans3(int ii2,int ii3){
        int argenf3 = 3;
        int argad3 = 6;
        int nott2 = 0;
        int nott3 = 0;
        nott2 = argenf3*ii3;
        nott3 = argad3*ii2;
        int cc2 = nott2+nott3;
        return cc2;
    }
}