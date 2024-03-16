

# MyDoctor
![image](https://github.com/Michal-Sta/Formify/assets/9118085/a1245f92-f068-4fc8-9bfe-7344f7ed814a)

## Project Overview:

"ZnanyLekarz" currently holds a "monopoly," and unfortunately, there are no interesting alternatives online.

**Main Features**
- [ ] WebApp

*Client features*
- [ ] List of available doctors with filtering options by specialization, 
- [ ] Availability on a particular day, and location (city).
- [ ] Appointment booking. 
- [ ] Appointment rating with reviews.
- [ ] Appointment cancellation.

*Admin/doctor panel*
- [ ] Ability to add appointment slots and new locations for a doctor.
- [ ] Confirmation of booked appointments by the doctor - manual or automatic.
- [ ] Auto calendar - add free slots depends on settings

**Possible but not necessary features:**
- [ ] Chat with the doctor.
- [ ] Read data from health document such .pdf
- [ ] Medical documentation accessible only to the doctor with whom the appointment is scheduled.
- [ ] Email confirmation of appointments.
- [ ] Sms message with approve
- [ ] Some Ai - but simple with choose the best doc for ur description

## Technologies:
- [ ] .NET 8, 
- [ ] EF Core
- [ ] React
- [ ] Tailwind - learn!
- [ ] RabbitMQ/Kafka - would like to learn more, 
- [ ] MongoDB - would like to learn but SQL-Server will be better option?
- [ ] Azure - learn!
- [ ] Docker
- [ ] MicroFrontends - would like to learn but dunno if it needed
- [ ] SignalR

## Technological Assumptions:
-   Utilization of .NET 8 for backend development.
-   Implementation of React/Angular for frontend development.
-   Integration of RabbitMQ/Kafka for messaging.
-   Adoption of MongoDB for database storage, with potential consideration of Azure services.

## Roadmaps
- [ ] Miro - try event storming (add screens here after)
- [x] Architecture - how, where, when, why? - C4 Diagram
- [x] Init solutions - structure of projects
- [x] Database init (Add diagram here)
- [x] Branding - color, etc 
- [x] Frontend project init and research UI/UX - use something ready
- [ ] Auth (bleh) + Login/Register page
- [ ] Admin panel
- [ ] User panel

## Diagrams
C4 diagram: 
- Context

![image](https://github.com/Michal-Sta/Formify/assets/9118085/1b526106-ebc1-49ab-ad74-9083e8059a92)

- Containers

![image](https://github.com/Michal-Sta/Formify/assets/9118085/90634df2-7145-46d8-a056-0262c401e09c)

- Components

![image](https://github.com/Michal-Sta/MyDoctor/assets/9118085/dc4d0e37-1175-42e2-8b54-e81263434b06)


## Event storming

![image](https://github.com/Michal-Sta/MyDoctor/assets/9118085/2b697d49-6f14-4c4c-a975-1b6593fb0910)

## Diagram DB

![image](https://github.com/Michal-Sta/MyDoctor/assets/9118085/02866baf-8e8b-47dc-a27a-bef054007078)

## Research UI

- https://www.microapp.io/ai-component-generator
- tailwind material
- https://tailwindcomponents.com/?ref=material-tailwind
- https://www.creative-tim.com/learning-lab/tailwind/react/alerts/notus?ref=nr-index&_ga=2.186812449.824193666.1710532797-1058424977.1710532797

## Research Technology

- https://tanstack.com/query/latest/docs/framework/react/overview
- https://www.npmjs.com/package/react-error-boundary
- https://auth0.com/docs/quickstart/backend/aspnet-core-webapi/01-authorization
