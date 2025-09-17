﻿using SistemaCelulares.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999-0000", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "98888-0000", modelo: "iPhone 13", imei: "222222222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");