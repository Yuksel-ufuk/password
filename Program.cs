< !DOCTYPE html >
< html >
    < head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < meta name = "keywords" content = "3DPrinterBaskı" >
    < meta name = "description" content = "açıklama" >
    < title > 3DPrinterBaskı </ title >
    < style >
        .formDiv{
width: 40 %;
    background - color: rgb(168, 209, 224);

}
    </ style >
    </ head >


< body >
    < div class= "formDiv" >



    < form >
        < table >
            < tr >
                < td > Adınız:</ td >
                < td >< input type = "text" ></ td >
            </ tr >
            < tr >
                < td > Soyadınız:</ td >
                < td >< input type = "text" ></ td >
            </ tr >
            < tr >
                < td > Email Adres:</ td >
                < td >< input type = "email" ></ td >
            </ tr >
            < tr >
                < td > Şifre:</ td >
                < td >< input type = "password" ></ td >
            </ tr >
            < tr >
                < td > Cinsiyet:</ td >
                < td >
                    < input id = "erkekRadio" type = "radio" name = "cinsiyetRadiyo" value = "Erkek" >
                    < label for= "erkekradio" > Erkek </ label >


                    < input id = "kadınRadio" type = "radio" name = "cinsiyetRadiyo" value = "Kadın" >
                    < label for= "kadınradio" > Kadın </ label >
                </ td >
                < tr >
                </ tr >
                < td > Ülke:</ td >
                < td >
                    < input id = "türkiyeRadio" type = "radio" name = "türkiyeRadiyo" value = "türkiy" >
                    < label for= "türkiyeRadio" > TC </ label >


                    < input id = "kktcRadio" type = "radio" name = "türkiyeRadiyo" value = "kktc" >
                    < label for= "kktcRadio" > KKTC </ label >
                </ td >
                < tr >
                    < td > Doğum Tarihi:</ td >
                    < td >< input type = "date" </ td >
                </ tr >
                < tr >
                    < td colspan = "2" >< input type = "file" ></ td >
                </ tr >
                < tr >
                    < td colspan = "2" >< textarea name = "" id = "" cols = "30" rows = "10" placeholder = "Mesajınız" ></ textarea ></ td >
                </ tr >
                < tr >
                    < tr >
                    < td > Okudum < br /> Onaylıyorum. < input type = "radio" name = "sozlesmeRadio" ></ td >
                    </ tr >
                    < tr >
                    < td > Onaylamıyorum. < input type = "radio" name = "sozlesmeRadio" ></ td >
                    </ tr >


                </ tr >


            </ tr >

        </ table >
        < tr colspan = "2" >
            < input type = "submit" value = "Gönder" style = "margin-right: 5px" >
            < input type = "reset" value = "Temizle" >
         </ td >


    < form >
    </ div >
</ body >
