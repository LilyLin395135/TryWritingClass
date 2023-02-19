//【可以使用以下代碼創建一個 Car 的物件】
//這段放在下面會錯誤，要放在類別、方法上面

//創建Car類別的實例，並傳入建構子所需的參數
//使用 new 關鍵字創建了一個 Car 的物件，並將其指派給名為 myCar 的變數。
Car myCar = new Car(2022, "Toyota", "Camry");
//使用Car類別的屬性，將年分、製造商、和車型屬性分別設定為2023、
myCar.Year = 2023;
myCar.Make = "Honda";
myCar.Model = "Accord";
//使用Car類別的方法，啟動和停止汽車
myCar.Start();
myCar.Stop();

//叫用子類別
ElectricCar myElectricCar = new ElectricCar(2023, "Skoda", "Tida", 80);
myElectricCar.Year = 2023;
myElectricCar.Make = "Benz";
myElectricCar.Model = "BBB";
myElectricCar.Start();
myElectricCar.Charge();


//---------------------------------------------

//【在下述代碼中，我們定義了一個名為 Car 的類別，
//它有三個屬性（Make、Model 和 Year），以及兩個方法（Start() 和 Stop()）。】

//定義 Car 類別
public class Car //public讓變數開頭大寫
{
    //定義Car類別的欄位Field
    //欄位都是private
    //?欄位是放在類別結構中的哪裡?他有甚麼功用?
    //欄位設為私有，另在下面使用public的屬性property來設定set和取得get這些欄位的值
    private int _year;//欄位Field的變數開頭用_字母小寫
    private string _make;
    private string _model;

    //定義Car類別的建構子Constructor
    //?這裡不懂建立後的作用。
    public Car(int year, string make, string model)//看最上面創建物件後有懂這一行了
    {
        _year = year;//?這邊還是不懂
        _make = make;
        _model = model;
    }

    //定義Car類別的屬性Property
    //public讓變數開頭大寫
    //get讓別人取得它的值、set讓別人設置它的值。分號放裡面
    //在欄位設為私有，在屬性property設為public設定set和取得get這些欄位的值
    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }
    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    //定義Car類別的方法Method
    //void功用：不會在完成時傳回值。
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }
    public void Stop()
    {
        Console.WriteLine("The car is stopped.");
    }
}

//【繼承】
//定義ElectricCar類別class(子類別Child Class/衍生類別Derived Class)，
//它繼承自Car類別(父類別Parent Class/基礎類別Base Class)。
//除了繼承 Car 類別中的所有屬性和方法之外，
//ElectricCar 類別還新增了一個名為 batteryCapacity 的屬性和相應的設定和取得方法。
public class ElectricCar : Car
{
    //定義ElectricCar類別的欄位Field
    private int _batteryCapacity;

    //定義ElectricCar類別的建構子
    public ElectricCar(int year, string make, string model, int batteryCapacity)
        : base(year, make, model)//使用base關鍵字呼叫父類別的建構子
    {
        _batteryCapacity = batteryCapacity;
    }

    //定義 ElectricCar類別的屬性
    public int BatteryCapacity
    {
        get { return _batteryCapacity; }
        set { _batteryCapacity = value; }
    }

    //定義ElectricCar類別的方法
    public void Charge()
    {
        Console.WriteLine("The electric car is charging.");
    }
}