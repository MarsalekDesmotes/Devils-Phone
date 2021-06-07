using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canavar : MonoBehaviour
{
    Vector3 pointA = new Vector3(1, (float)-2.51, 0);
    Vector3 pointB = new Vector3(14, (float)-2.51, 0);
    static int x=-10;
    /*int sayac = 0;*/
    
    public float  hiz = 0.3f;
    public float konum_ayarlayici;
    public float zaman;
    public static int sayac;





    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        /*Invoke("FixedUpdate", 2);*/
    }

    // Update is called once per frame
    void Update()
    {

    }

    
void yuru()
    {
        /* if (sayac < 1)
       {
           sayac++;
           System.Threading.Thread.Sleep(3000);
       } */

        

        konum_ayarlayici += Time.deltaTime * hiz; // her update çaðrýmýnda topla ile deðeri artýrýyorum eðer topla deðeri içeride tanýmlanmýþ olsaydý her seferinde ilk deðerinden baþlayacaktý 

        transform.position = Vector3.Lerp(pointA, pointB, konum_ayarlayici); //noktaya kadar gitme iþlemi
        if (konum_ayarlayici >= 1)// a + (b -a) * konum_ayarlayici eðer konum_ayarlayici == 1 ise a'lar birbirini götürür ve sonuç b ye yani varacaðýmýz noktaya eþitlenmiþ olur dikkat ederseniz zaten konum_ayarlayici deðeri zaman 0.10 olsa 0.10*1'den baþlayarak yavaþ yavaþ artacak ve bu deðer 1 olduðunda b'ye ulaþmýþ olacak 
        {
            x = x * -1;
            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
            var tmp = pointB; // pointB bir nesne olduðu için bu deðiþkenin içindeki deðerleri de nesne tipinde bir deðiþken olan var'a atýyoruz 
            pointB = pointA;
            pointA = tmp;
            konum_ayarlayici = 0;
        }
    }
    private void FixedUpdate()
    {
        zaman += Time.deltaTime;
        if (zaman >= 0.5)
        {
            yuru();
        }
        
    }
}
