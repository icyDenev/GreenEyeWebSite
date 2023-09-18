# GreenEyeWebSite

## 1. Used Technologies
### Network:
- LoRaWaN (The Things Network)
### Programming Languages:
- Arduino (Based on C)
- C#
- JavaScript
- SQL
### Markup and Style
Languages:
- HTML (and the hybrid CSHTML/Razor)
- CSS
### IDEs:
- Arduino IDE
- Visual Studio
### Software:
- ArduPilot
- MS SSMS
### Tools and Frameworks:
- .NET
- Entity Framework
- M2MQTT
### Meteorological Module Hardware:
- Arduino Uno Rev. 3
- NDIR CO2 sensor
- CO sensor
- O3 sensor
- Vacuum pump PM2.5 sensor
- LoRaWaN module
### Plane Hardware:
- Pixhawk flight controller
- Remote Control
- Brushless Electromotor
- Switch
- Buzzer
- GPS
- AC/DC Converter
- Battery
- ESC (Electronic Speed Control

## 2. Work Process, Problems, and Solutions
### Phase 1: Role Assignment and Work Process Planning 
For my second project, I was ready to take responsibility and become one of the leaders of the club. 
That is why when my teammates and I began the project planning and assigning the roles, I opted 
to be a leader of the software development department and part of the leadership core of the 
team, which had enlarged to eleven people! Like the last project, the team concluded that it is 
better to develop the two physical modules of the project at the same time. Furthermore, some of 
us also decided to join the Entrepreneurship Club and try to transform the project into a training
business company as part of Junior Achievement’s Students’ Company program.

### Phase 2: Sensors and Microcontroller Testing / Web App Setup 
Similarly to the VituSat-1 project, we began working on Green Eye by testing the sensors and 
microcontrollers of the plane and the meteorological module. I had to test the sensors alongside 
three of my teammates, but due to their lack of experience, I had to teach them the basics by 
showing them how the sensors work, how to connect them together, and how to find out whether 
those sensors work properly or not.
Simultaneously, I began the web app development by choosing the software design pattern of 
the website. I decided to build the website based on the MVC (Model-View-Controller) model, 
because this pattern takes a thin client approach, which results in a low performance demand 
from client’s side as the Model (or the data) is stored and processed on the server.
 
### Phase 3: Plane and Meteorological Module Sensor Assembly / SQL DB Setup 
After the testing phase, we began assembling the plane and the meteorological module. Due to 
the experience we gained during the VituSat-1 project, we managed to merge the sensors’ codes 
for the meteorological module without any problems at all.
We also connected all the sensors of the plane module in order to test the entire system. Using
the ArduPilot software, we managed to see that all plane sensors, controllers, servos, and the 
electromotor work just fine together. However, it turned out that the electromotor and the carbon 
tube, which it is attached on, are not compatible. That is why we had to 3D design and print a new 
part for the plane. Fortunately, one of the boys in the team had experience with 3D modeling and 
quickly created the model of that essential part.
At the same time, I also managed to quickly setup the SQL Database using the MS SSMS (Microsoft 
SQL Server Management System). I choose to work with SQLEXPRESS mainly because of its good
data processing speed and compatibility with one of the best (in my opinion) ORMs – Entity 
Framework. Due to my prior experience with RDBMSs, I managed to connect the database and 
the website in almost no time.

### Phase 4: Plane Full System Test / Data Transfer via LoRaWaN and 
Web App Demo Data Test 
We also successfully connected the meteorological module to the website. The path of the data is 
as follows: 1) the data gathered from the airplane is sent by the LoRaWaN IoT module to the nearest 
LoRaWaN ground end node; 2) By using M2MQTT, we redirect the gathered data to our .NET Web 
API; 3) the controller of the app converts the data into a class custom object; 4) that class object is 
sent to the database as a record, containing the air pollution data for one of the hexagonal zones 
over the monitored areas.

## 3. Final Results
We managed to create a fully working plane with meteorological module inside of it and a Web 
App where all the gathered data is visualized as clickable hexagons.
