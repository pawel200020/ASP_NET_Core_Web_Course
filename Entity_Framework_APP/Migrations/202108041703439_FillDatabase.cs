namespace Entity_Framework_APP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDatabase : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Chevelle Malibu','18.0','8','307.0','130.0','3504.','12.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Buick Skylark 320','15.0','8','350.0','165.0','3693.','11.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Satellite','18.0','8','318.0','150.0','3436.','11.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Rebel SST','16.0','8','304.0','150.0','3433.','12.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Torino','17.0','8','302.0','140.0','3449.','10.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Galaxie 500','15.0','8','429.0','198.0','4341.','10.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Impala','14.0','8','454.0','220.0','4354.','9.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Fury iii','14.0','8','440.0','215.0','4312.','8.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Pontiac Catalina','14.0','8','455.0','225.0','4425.','10.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Ambassador DPL','15.0','8','390.0','190.0','3850.','8.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Citroen DS-21 Pallas','0','4','133.0','115.0','3090.','17.5','70','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Chevelle Concours (sw)','0','8','350.0','165.0','4142.','11.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Torino (sw)','0','8','351.0','153.0','4034.','11.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Satellite (sw)','0','8','383.0','175.0','4166.','10.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Rebel SST (sw)','0','8','360.0','175.0','3850.','11.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Dodge Challenger SE','15.0','8','383.0','170.0','3563.','10.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth ''Cuda 340','14.0','8','340.0','160.0','3609.','8.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Mustang Boss 302','0','8','302.0','140.0','3353.','8.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Monte Carlo','15.0','8','400.0','150.0','3761.','9.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Buick Estate Wagon (sw)','14.0','8','455.0','225.0','3086.','10.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Toyota Corolla Mark ii','24.0','4','113.0','95.00','2372.','15.0','70','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Duster','22.0','6','198.0','95.00','2833.','15.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Hornet','18.0','6','199.0','97.00','2774.','15.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Maverick','21.0','6','200.0','85.00','2587.','16.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Datsun PL510','27.0','4','97.00','88.00','2130.','14.5','70','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Volkswagen 1131 Deluxe Sedan','26.0','4','97.00','46.00','1835.','20.5','70','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Peugeot 504','25.0','4','110.0','87.00','2672.','17.5','70','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Audi 100 LS','24.0','4','107.0','90.00','2430.','14.5','70','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Saab 99e','25.0','4','104.0','95.00','2375.','17.5','70','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('BMW 2002','26.0','4','121.0','113.0','2234.','12.5','70','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Gremlin','21.0','6','199.0','90.00','2648.','15.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford F250','10.0','8','360.0','215.0','4615.','14.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevy C20','10.0','8','307.0','200.0','4376.','15.0','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Dodge D200','11.0','8','318.0','210.0','4382.','13.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Hi 1200D','9.0','8','304.0','193.0','4732.','18.5','70','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Datsun PL510','27.0','4','97.00','88.00','2130.','14.5','71','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Vega 2300','28.0','4','140.0','90.00','2264.','15.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Toyota Corolla','25.0','4','113.0','95.00','2228.','14.0','71','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Pinto','25.0','4','98.00','0','2046.','19.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Volkswagen Super Beetle 117','0','4','97.00','48.00','1978.','20.0','71','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Gremlin','19.0','6','232.0','100.0','2634.','13.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Satellite Custom','16.0','6','225.0','105.0','3439.','15.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Chevelle Malibu','17.0','6','250.0','100.0','3329.','15.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Torino 500','19.0','6','250.0','88.00','3302.','15.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Matador','18.0','6','232.0','100.0','3288.','15.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Impala','14.0','8','350.0','165.0','4209.','12.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Pontiac Catalina Brougham','14.0','8','400.0','175.0','4464.','11.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Galaxie 500','14.0','8','351.0','153.0','4154.','13.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Fury iii','14.0','8','318.0','150.0','4096.','13.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Dodge Monaco (sw)','12.0','8','383.0','180.0','4955.','11.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Country Squire (sw)','13.0','8','400.0','170.0','4746.','12.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Pontiac Safari (sw)','13.0','8','400.0','175.0','5140.','12.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Hornet Sportabout (sw)','18.0','6','258.0','110.0','2962.','13.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Vega (sw)','22.0','4','140.0','72.00','2408.','19.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Pontiac Firebird','19.0','6','250.0','100.0','3282.','15.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Mustang','18.0','6','250.0','88.00','3139.','14.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Mercury Capri 2000','23.0','4','122.0','86.00','2220.','14.0','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Opel 1900','28.0','4','116.0','90.00','2123.','14.0','71','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Peugeot 304','30.0','4','79.00','70.00','2074.','19.5','71','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Fiat 124B','30.0','4','88.00','76.00','2065.','14.5','71','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Toyota Corolla 1200','31.0','4','71.00','65.00','1773.','19.0','71','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Datsun 1200','35.0','4','72.00','69.00','1613.','18.0','71','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Volkswagen Model 111','27.0','4','97.00','60.00','1834.','19.0','71','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Cricket','26.0','4','91.00','70.00','1955.','20.5','71','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Toyota Corolla Hardtop','24.0','4','113.0','95.00','2278.','15.5','72','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Dodge Colt Hardtop','25.0','4','97.50','80.00','2126.','17.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Volkswagen Type 3','23.0','4','97.00','54.00','2254.','23.5','72','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Vega','20.0','4','140.0','90.00','2408.','19.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Pinto Runabout','21.0','4','122.0','86.00','2226.','16.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Impala','13.0','8','350.0','165.0','4274.','12.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Pontiac Catalina','14.0','8','400.0','175.0','4385.','12.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Fury III','15.0','8','318.0','150.0','4135.','13.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Galaxie 500','14.0','8','351.0','153.0','4129.','13.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Ambassador SST','17.0','8','304.0','150.0','3672.','11.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Mercury Marquis','11.0','8','429.0','208.0','4633.','11.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Buick LeSabre Custom','13.0','8','350.0','155.0','4502.','13.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Oldsmobile Delta 88 Royale','12.0','8','350.0','160.0','4456.','13.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chrysler Newport Royal','13.0','8','400.0','190.0','4422.','12.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Mazda RX2 Coupe','19.0','3','70.00','97.00','2330.','13.5','72','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Matador (sw)','15.0','8','304.0','150.0','3892.','12.5','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Chevelle Concours (sw)','13.0','8','307.0','130.0','4098.','14.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Gran Torino (sw)','13.0','8','302.0','140.0','4294.','16.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Plymouth Satellite Custom (sw)','14.0','8','318.0','150.0','4077.','14.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Volvo 145e (sw)','18.0','4','121.0','112.0','2933.','14.5','72','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Volkswagen 411 (sw)','22.0','4','121.0','76.00','2511.','18.0','72','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Peugeot 504 (sw)','21.0','4','120.0','87.00','2979.','19.5','72','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Renault 12 (sw)','26.0','4','96.00','69.00','2189.','18.0','72','Europe')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Pinto (sw)','22.0','4','122.0','86.00','2395.','16.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Datsun 510 (sw)','28.0','4','97.00','92.00','2288.','17.0','72','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Toyota Corolla Mark II (sw)','23.0','4','120.0','97.00','2506.','14.5','72','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Dodge Colt (sw)','28.0','4','98.00','80.00','2164.','15.0','72','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Toyota Corolla 1600 (sw)','27.0','4','97.00','88.00','2100.','16.5','72','Japan')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Buick Century 350','13.0','8','350.0','175.0','4100.','13.0','73','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('AMC Matador','14.0','8','304.0','150.0','3672.','11.5','73','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Malibu','13.0','8','350.0','145.0','3988.','13.0','73','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Ford Gran Torino','14.0','8','302.0','137.0','4042.','14.5','73','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Dodge Coronet Custom','15.0','8','318.0','150.0','3777.','12.5','73','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Mercury Marquis Brougham','12.0','8','429.0','198.0','4952.','11.5','73','US')");
            Sql("INSERT INTO dbo.Cars(Carm,MPG,Cylinders,Displacement,Horsepower,Weight,Acceleration,Model,Origin) VALUES ('Chevrolet Caprice Classic','13.0','8','400.0','150.0','4464.','12.0','73','US')");


        }

        public override void Down()
        {
        }
    }
}
