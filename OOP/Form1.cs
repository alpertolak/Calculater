using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        private double sayi1;
        private double sayi2;
        private String LastNode = null;
        private String Operator = null;
        private String HandledDataString = null;
        private String dataString = null;
        private bool IsHandledTurn = false;
        private bool calculated = false;
        private bool isNotMath = true;
        private bool isLastNodeOper = false;
        private bool islastNodePoint = false;
        private bool isFirstNodeNegative = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void setOperator(char oper)
        {
            this.Operator = oper.ToString();
        }
        private void setLastNode(bool oper)
        {
            String dataString = DataInput.Text;
            try
            {
                //gelen bilgiye göre girilen input üzerindeki son karakter alınıyor.
                if (oper) LastNode = dataString[dataString.Length - 2].ToString();
                else LastNode = dataString[dataString.Length - 1].ToString();
            }
            catch {
                dataString = null;
            }

            if (LastNode == "/" || LastNode == "*" || LastNode == "-" || LastNode == "+") {isLastNodeOper = true; Operator = LastNode; }

            if (LastNode == ",") islastNodePoint = true; //son karakter virgül ise islastNodePoint true olarak işaretleniyor.
            else islastNodePoint = false;

        }
        private void insertInputNode(String nodeToInsert, bool oper)
        {
            //kullanılmak üzere data input verisi çekiliyor.
            String dataString = DataInput.Text;

            
            isCalculated(false); //hesaplama tuşuna basılması kontrolü

            if (nodeToInsert == ",")
            {
                //son karakterin bir işlem olması durumu kontrol ediliyor.
                isUseOperator();

                if (LastNode == ",") return;
                else if (dataString != "") DataInput.Text += nodeToInsert;

                //son karakter operatör değil
                isLastNodeOper = false;

                setLastNode(false);
            }
            else if (oper)
            {
                setLastNode(false);

                //hesaplandı bilgisi true yapılarak giriş ve sonuç kısımlarının temizlenmesi sağlanıyor.
                isCalculated(true);

                //gelen nodeToInsert verisi ınput kısmınına son karakter olarak eklenir.
                if (dataString == "") return;
                else if (LastNode == ",") DataInput.Text += "0" + " " + nodeToInsert + " ";
                

                //son karakter operatore denk gelicel şekilde seçiliyor.
                setLastNode(true);

                //son karakterin bir işlem olması durumu kontrol ediliyor.
                isUseOperator();
                
                if (dataString == "0") ;
                else if (dataString != "0") { DataInput.Text += " " + nodeToInsert + " "; }


                //girilen en son ınput karakterini belirlemek için setLastNode çağırılıyor.
                setLastNode(false);
            }
            else
            {
                if (dataString == "0") DataInput.Text = "";

                DataInput.Text += nodeToInsert;
                result.Text = "";

                //girilen en son ınput karakterini belirlemek için setLastNode çağırılıyor.
                setLastNode(false);
            }
        }
        private void isCalculated(bool oper)
        {
            //kullanıcının hesapla butonuna basıp basmadığını takip eder
            if (calculated == true)
            {
                //hesaplandı bilgisi sıfırlanır.
                calculated = false;
                Operator = null;
            }
        }
        private void isUseOperator()
        {
            //son karakterin işlem olması durumunda yeni taleb edilen işlemle yer değiştirir.
            if (isLastNodeOper)
            {
                String dataString = DataInput.Text;
                try
                {
                    DataInput.Text = dataString.Substring(0, (dataString.Length - 3));
                    isLastNodeOper = false;
                }
                catch { }
            }
        }

        private void setNumbersPriority()
        {

            while (true)
            {
                //gelen veririn nerden geldiği belirlenir.
                if (IsHandledTurn == true) { dataString = HandledDataString; }
                else  { dataString = DataInput.Text;}
                
                //girilen verinin detaylarının tutulacağı değişkenler tanımlanıyor
                int numberIn = -1;
                int numberOut = -1;
                int indexOf = 0;
                int Bound = 0;
                int countOfWhile3 = 0;
                int numberLength = 0;
                string sayi2String = null;

                //bool değişkenler 
                bool IsNotPriority = true;


                //dataInput içerisinde işlem önceliği olan operator olması durumu kontrol ediliyor.

                while (true)
                {

                    if (indexOf == dataString.Length) break;

                    else if (dataString[indexOf] == '/' || dataString[indexOf] == '*') //dataString içinde '/' , '*' var ise bu komut bloğuna girer.
                    {
                        setOperator(dataString[indexOf]); //operator dataString içinde denk gelinen / veya * olarak kaydeliyor.
                        Bound = indexOf + 2; //Bound değişkeni, indexOf'un bulunduğu konumdan 2 fazlasına konumlandırılıyor.
                        IsNotPriority = false;
                        break;
                    }
                    indexOf++;
                }

                //eğer gönderilen girdinin son karakteri bir operatör veya boşluk ise bu blok çalışır. 
                if (LastNode == Operator || LastNode == " ") { isNotMath = true; dataString = null; isLastNodeOper = true; break;}
                else { isLastNodeOper = false; isNotMath = false; }

                //öncelikli işlem olmaması durumunda en dıştaki while kırılıyor.
                if (IsNotPriority) break;

                indexOf += 2; // bir sonraki işlem için indexOf konumu +2 ileriye alınıyor.

                while (true)
                {
                    if (indexOf == dataString.Length || dataString[indexOf] == ' ') //indexOf ilerlediği sırada yazı uzunluğuna veya bir boşluğa geldiği zaman bu bloğa girer.
                    {
                        sayi2 = Convert.ToDouble(dataString.Substring(Bound, ((indexOf - Bound)))); //indexOf değerine göre ikinci sayının bulunması için subString methodu kullanıyor.
                        sayi2String = dataString.Substring(Bound, ((indexOf - Bound))); //sayi2 kontrol edilebilmek için string olarak alınıyor.
                        numberOut = indexOf - 1;  //işlem önceliği olan bloğun son karakterinin bittiği nokta kaydediliyor.
                        break;
                    }
                    indexOf++;
                }

                indexOf -= sayi2String.Length + 4; //sayi2 uzunluğu kadar + 4 yapılarak indexOf ilk sayı için konumlandırılıyor.

                while (true)
                {
                    //indexOf düşme sırasında dataInput üzerinde eğer en başa dönerse bu if bloğuna girer.
                    if (indexOf == 0)
                    {
                        sayi1 = Convert.ToDouble(dataString.Substring(indexOf, (countOfWhile3 + 1))); //indexOf değerine göre ilk sayıyı bulmak için subString kullanıyor.
                        numberIn = indexOf; //işlem önceliği olan bloğun ilk karakterinin başladığı nokta kaydediliyor.
                        break;
                    }

                    //indexOf düşme sırasında dataInput üzerinde eğer bir boşluğa denk gelirse bu blouğa girer.
                    else if (dataString[indexOf] == ' ')
                    {
                        sayi1 = Convert.ToDouble(dataString.Substring(indexOf, (countOfWhile3 + 1)));//indexOf değerine göre ilk sayıyı bulmak için subString kullanıyor.
                        numberIn = indexOf + 1;//işlem önceliği olan işlemin başlangıç kısmı kaydeliyor(+1 eklenmesinin nedeni boşluk karakteri eksik veri girişine neden olmaktadır.)
                        break;
                    }
                    
                    indexOf--;
                    
                    countOfWhile3++; //indexOf düşme sırasında kaç kere düştüğünü saymak için countOfWhile bir arttırılır.
                }

                numberLength = numberOut - numberIn; //bitiş index - başlangıç index yapılarak sayının uzunluğu elde ediliyor.
                NumberPojo number = new NumberPojo(sayi1, sayi2, Operator, numberIn, numberOut, numberLength); //yukarda elde edilen veriler numberPojo sınıfına gönderilerek kaydediliyor.
                doMathSections(dataString, numberIn, numberLength, number.getResult()); //işlem öncelikleri yapılıp tekrar dataString değişkenine atanıyor.
            }

            //kalan toplama veya çıakrtma işlemlerinin yapılacağı bölüm çağırılıyor.
            setNumberDefault();

        }
        private void setNumberDefault()
        {
            while (true)
            {
                //son gelişmelerin olduğu dataString değişkeni eşitleniyor.
                if (IsHandledTurn == true) { dataString = HandledDataString; }
                else { dataString = DataInput.Text; }

                //eğer son karakter bir işlem veya boşluk ise, programın düzgün çalışması için break yardımıyla döngüden çıkılarak setNumberDefault atlanır.
                if (isLastNodeOper == true) { isNotMath = true; break; };

                //dataString içeriğinin boş olması durumu kontrol ediliyor.
                if (dataString == "") break;

                //girilen verinin detaylarının tutulacağı değişkenler tanımlanıyor
                int numberIn = -1;
                int numberOut = -1;
                int indexOf = 1;
                int Bound = 0;
                int countOfWhile3 = 0;
                int numberLength = 0;
                String sayi2String = null;

                //bool değişkenler 
                bool IsNotPriority = true;

                //datastring içinde soldan sağa doğru toplama veya çıkartma işlemlerini yapmak için çıkartma veya toplama işlemlerinin yerleri tespit ediliyor.
                while (true)
                {
                    if (indexOf == dataString.Length) break;

                    else if (dataString[indexOf] == '+' || dataString[indexOf] == '-') //dataString içinde '+' , '-' var ise bu komut bloğuna girer.
                    {
                        setOperator(dataString[indexOf]); //operator dataString içinde denk gelinen + veya - olarak kaydeliyor.
                        if (dataString[0] == '-') Bound = indexOf + 1;
                        else Bound = indexOf + 2; //Bound değişkeni, indexOf'un bulunduğu konumdan 2 fazlasına konumlandırılıyor.
                        IsNotPriority = false;
                        break;
                    }
                    indexOf++;
                }

                if (IsNotPriority) break;

                if (dataString[0] == '-')
                {
                    dataString = dataString.Remove(0, 1);
                    isFirstNodeNegative = true;
                    indexOf++;
                }
                else indexOf += 2; // bir sonraki işlem için indexOf konumu +2 ileriye alınıyor.




                while (true)
                {
                    if (indexOf == dataString.Length || dataString[indexOf] == ' ') //indexOf ilerlediği sırada yazı uzunluğuna veya bir boşluğa geldiği zaman bu bloğa girer.
                    {
                        sayi2 = Convert.ToDouble(dataString.Substring(Bound, ((indexOf - Bound)))); //indexOf değerine göre ikinci sayının bulunması için subString methodu kullanıyor.
                        sayi2String = dataString.Substring(Bound, ((indexOf - Bound)));
                        numberOut = indexOf - 1;  //işlem önceliği olan bloğun son karakterinin bittiği nokta kaydediliyor.
                        break;
                    }
                    indexOf++;
                }

                indexOf -= sayi2String.Length + 4;

                ////son karakter virgül ise programın düzgün çalışması için kaydırma işlemi 5 yapılır
                //if (islastNodePoint) indexOf -= sayi2.ToString().Length + 5;
                
                while (true)
                {
                    //indexOf düşme sırasında dataInput üzerinde eğer en başa dönerse bu if bloğuna girer.
                    if (indexOf == 0)
                    {
                        sayi1 = Convert.ToDouble(dataString.Substring(indexOf, (countOfWhile3 + 1))); //indexOf değerine göre ilk sayıyı bulmak için subString kullanıyor.
                        numberIn = indexOf; //işlem önceliği olan bloğun ilk karakterinin başladığı nokta kaydediliyor.
                        break;
                    }

                    //indexOf düşme sırasında dataInput üzerinde eğer bir boşluğa denk gelirse bu blouğa girer.
                    else if (dataString[indexOf] == ' ')
                    {
                        sayi1 = Convert.ToDouble(dataString.Substring(indexOf, (countOfWhile3 + 1)));//indexOf değerine göre ilk sayıyı bulmak için subString kullanıyor.
                        numberIn = indexOf + 1;//işlem önceliği olan işlemin başlangıç kısmı kaydeliyor(+1 eklenmesinin nedeni boşluk karakteri eksik veri girişine neden olmaktadır.)
                        break;
                    }

                    indexOf--;
                    countOfWhile3++; //indexOf düşme sırasında kaç kere düştüğünü saymak için countOfWhile bir arttırılır.
                }

                numberLength = numberOut - numberIn; //bitiş index - başlangıç index yapılarak sayının uzunluğu elde ediliyor.
                if (isFirstNodeNegative) { sayi1 = Convert.ToDouble(sayi1.ToString().Insert(0, "-")); isFirstNodeNegative = false; }
                NumberPojo number = new NumberPojo(sayi1, sayi2, Operator, numberIn, numberOut, numberLength); //yukarda elde edilen veriler numberPojo sınıfına gönderilerek kaydediliyor.
                doMathSections(dataString, numberIn, numberLength, number.getResult()); //işlem öncelikleri yapılıp tekrar dataString değişkenine atanıyor.
                
            }
        }
        private void doMathSections(String dataString,int numberIn,int NumberLength,double mathInput)
        {
            HandledDataString = dataString.Remove(numberIn, NumberLength+1); //gelen başlangıç değerine göre işlem önceliği olan işlem bölümü tekrar yerleştirilmek üzere siliyor.

            HandledDataString = HandledDataString.Insert(numberIn, mathInput.ToString()); //başlangıç noktasından itibaren işlem önceliği olan işlemin cevabı ekleniyor.
            
            IsHandledTurn = true;  //bu işlem bloğunın kullanıldığnı kaydetmek için kullanılan IsHandledTurn değişkeni true yapılıyor.

            //eğer program bu kısma geldiyse matematik işlemi gerçekleşmiş demektir. isNotMath false olarak işaretlernir. 
            isNotMath = false;

            //eğer program bu kısma geldiyse matematik işlemi gerçekleşmiş demektir. isLastNodeOper false olarak işaretlernir.
            isLastNodeOper = false;
        }

        private void doMath() {

            //sayıların tanımlanması ve öcelikliden başlayarak işlemleri yapması için setNumberPriority methodu çağırılıyor.
            setNumbersPriority();
            
            IsHandledTurn = false;//eğer işlemin üzerine sayı girişi devam ederse programın akışı bozulmasın diye ISHandelTurn false yapılır.
                                  //eğer gelen data boş ise result kısmı "0" yapılıyor.

            if (dataString == null || dataString == "" || dataString == "0" || dataString == " ") result.Text = "0";
            else if (isNotMath) result.Text = "0"; //eğer gelen girdinin içinde bir matematik işlemi yok ise sayı olduğu gibi yazdırılııyor.
            else result.Text = doScale(dataString);

        }
        private string doScale(String resultString)
        {
            resultString = resultString.Trim();
            bool isComma = false;
            isFirstNodeNegative = false;
            int resultStringLength; //uzunluk değişkeni tanımlanıyor.

            String[] resultStringArray = null;//sonucunun , den öncesi ve sonrası tutacak array tanımlanıyor.

            if (resultString.Contains(","))
            {
                resultStringArray = resultString.Split(',');//sonucunun , den öncesi ve sonrası kaydediliyor.

                resultString = resultStringArray[0];//sonucun virgülden öncesi alınıyor.
                isComma = true;
            }
            if (resultString[0] == '-')
            {
                resultString = resultString.Remove(0, 1);
                isFirstNodeNegative = true;
            }
            
            resultStringLength = resultString.Length;//başında eksi varsa uzunluk bir kısaltılıyor.
             

            //kaç nokta olacağı bilgisini tutan değişkenler tanımlanıyor.
            int pointAmount = 0;
            int countPoint = 0;

            //verinin uzunluğuna göre kaç nokta olacağı belirleniyor.
            if (resultStringLength >= 16) pointAmount = 5;
            else if (resultStringLength >= 13) pointAmount = 4;
            else if (resultStringLength >= 10) pointAmount = 3;
            else if (resultStringLength >= 7) pointAmount = 2;
            else if (resultStringLength >= 4) pointAmount = 1;

            for (int i = 3; countPoint < pointAmount; i+=3)
            {
                resultString = resultString.Insert((resultStringLength - i), ".");
                countPoint++;
            }

            resultStringLength = resultString.Length; // karşıklığı önlemek için tekrar uzunluk alınıyor.

            //eğer virgül içeren bir sonuç dönerse virgülden sonrası eklenmesi için if komut bloğu çalışır.
            if (isFirstNodeNegative) { resultStringLength++; resultString = resultString.Insert(0, "-"); isFirstNodeNegative = false; }
            if (isComma) return resultString = resultString.Insert((resultStringLength), ("," + resultStringArray[1]));
            
            else return resultString;

        }
        private void calculate_Click(object sender, EventArgs e)
        {
            DataInput.Text = result.Text;
            result.Text = "";

            IsHandledTurn = false;//eğer işlemin üzerine sayı girişi devam ederse programın akışı bozulmasın diye ISHandelTurn false yapılır.
                                  //eğer gelen data boş ise result kısmı "0" yapılıyor.
        }
        private void zero_Click(object sender, EventArgs e)
        {
            insertInputNode("0",false);
            doMath();
        }
        private void one_Click(object sender, EventArgs e)
        {
            insertInputNode("1", false);
            doMath();
        }
        private void two_Click(object sender, EventArgs e)
        {
            insertInputNode("2", false);
            doMath();
        }
        private void three_Click(object sender, EventArgs e)
        {
            insertInputNode("3",false);
            doMath();
        }
        private void four_Click(object sender, EventArgs e)
        {
            insertInputNode("4", false);
            doMath();
        }
        private void five_Click(object sender, EventArgs e)
        {
            insertInputNode("5", false);
            doMath();
        }
        private void six_Click(object sender, EventArgs e)
        {
            insertInputNode("6", false);
            doMath();
        }
        private void seven_Click(object sender, EventArgs e)
        {
            insertInputNode("7", false);
            doMath();
        }
        private void eight_Click(object sender, EventArgs e)
        {
            insertInputNode("8", false);
            doMath();
        }
        private void nine_Click(object sender, EventArgs e)
        {
            insertInputNode("9", false);
            doMath();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            DataInput.Text = "0";
            result.Text = "";
            HandledDataString = null;
            IsHandledTurn = false;
        }
        private void divide_Click(object sender, EventArgs e)
        {
            insertInputNode("/", true);
            doMath();
        }
        private void crush_Click(object sender, EventArgs e)
        {
            insertInputNode("*", true);
            doMath();

        }
        private void extraction_Click(object sender, EventArgs e)
        {
            insertInputNode("-", true);
            doMath();
        }
        private void plus_Click(object sender, EventArgs e)
        {
            insertInputNode("+", true);
            doMath();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void deleteLastNode_Click(object sender, EventArgs e)
        {
            dataString = DataInput.Text;
            try
            {
                if (dataString[dataString.Length - 1] == ' ')
                {
                    DataInput.Text = dataString.Substring(0, dataString.Length - 3);
                    setLastNode(false);
                }
                else
                {
                    DataInput.Text = dataString.Substring(0, dataString.Length - 1);
                    setLastNode(false);
                }
                
            }
            catch {
                result.Text = "0";
            }
            doMath();

        }

        private void point_Click(object sender, EventArgs e)
        {
            insertInputNode(",", true);
            setLastNode(false);
            doMath();
        }

    }
}
