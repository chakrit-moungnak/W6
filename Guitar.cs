public class Guitar
{
    public string serial;
    public string price;
    public string builder;
    public string model;
    public string wood;

    public Guitar(string serial, string price, string builder, string model, string wood){
        this.serial = serial;
        this.price = price;
        this.builder = builder;
        this.model = model;
        this.wood = wood;
    }

    public string PrintGuitarInfomation(){
        return "Guitar Infomation : " + this.serial + " " + this.price + " " + this.builder + " " + this.model + " " + this.wood;
    }


}