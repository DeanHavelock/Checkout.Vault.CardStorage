# Checkout.Vault.CardStorage
 Checkout Clean Architecture Example. Author: Dean Havelock and collaborators.

A Pragmatic approach to implementing the Clean Architecture, It is assumed you know the benefits and tradeoffs and have chosen to go ahead with the Clean Architecture.

Aka: The Onion Architecture, Ports and Adapters Architecture, Clean Architecture, Hexagonal Architecture. 

Please note: This document provides pragmatic guidance, you should read it with the mindset to use what works for you and your team to give you the most benefit. Some aspects are subject to “It depends”, feel free to deviate, based on informed, pragmatic decisions, where beneficial to do so.

 

Clean Architecture Solution Structure:
Fundamentally this architecture separates responsibilities into pre-defined layers for the purpose of managing dependencies, the structure guides the next developer where to find & place their code. 

The layers are as follows:

{Company}.{Team/Context}.{Product}.Infrastructure

{Company}.{Team/Context}.{Product}.UI / API / Console / Lambda / Any Host as an application composition root.

{Company}.{Team/Context}.{Product}.Application

{Company}.{Team/Context}.{Product}.Core

A real solution could look something like this:
Checkout.Vault.CardStorage.Infrastructure

Checkout.Vault.CardStorage.Api

Checkout.Vault.CardStorage.Application

Checkout.Vault.CardStorage.Core

The Dependencies between projects as follows:
The Clean Architecture Project Dependency Diagram
Checkout.Vault.CardStorage.Infrastructure

 → Checkout.Vault.CardStorage.Core

Checkout.Vault.CardStorage.Api

      → Checkout.Vault.CardStorage.Infrastructure

      → Checkout.Vault.CardStorage.Application

      → Checkout.Vault.CardStorage.Core

Checkout.Vault.CardStorage.Application


      → Checkout.Vault.CardStorage.Core

Checkout.Vault.CardStorage.Core

      → N/A

*Notice how the Core has no project references, more on this later.

*Notice how the Api layer is the only project with a reference to Infrastructure.

*Notice how in the onion image, Infrastructure layer has a dependency on Application layer, you can add this reference, some choose to put their commands into the Application layer rather then the Core, Application already has a reference to the Core, I prefer a cleaner approach where Infrastructure only takes a dependency on Core, Microsoft has moved the application layer responsibilities into the core and removed this layer, see here. Either decision still allows the benefits of clean architecture design, In my experience the application layer has separation of concerns value, it’s up-to you on this.

Layers And Responsibilities:
 *DISCLAIMER: this is not an exhaustive list, more to come, if you have anything to contribute leave a comment:

Checkout.Vault.CardStorage.Infrastructure
Implement the Interfaces defined in the Core.

Implement connections to external dependencies.

These are the adapters to external dependencies: Database, network, file system, security.

 

Checkout.Vault.CardStorage.Api
Use the Application Composition Root to set-up dependency injection for Interfaces defined within the Core to Implemented types in Infrastructure.

Determination and Routing of Use Case scenarios via Command Types.

 

Checkout.Vault.CardStorage.Application
Implementation for Use Case Handlers.

Orchestration of a use case and transactional consistency boundary.

 

Checkout.Vault.CardStorage.Core
Interfaces for Infrastructure dependencies

In the Ports and Adapters Architecture the interfaces are known as Ports to be implemented as Adapters in Infrastructure layer

Domain models

We should keep the Domain as clean as possible, however… We make an informed decision to introduce a Nuget dependency on helpful libraries for example OneOf or MediatR, but we should limit the introduction of external dependency concerns, we should be asking ourselves should we introduce this dependency in the infrastructure layer, sometimes, we make a pragmatic informed decision to take on a dependency for convenience and as long as the tradeoffs are understood, it’s okay to deviate where pragmatic to do so.

Testing The Clean Architecture:
The Clean Architecture Testing Solution Structure: Integration, Unit and Acceptance
Checkout.Vault.CardStorage.Infrastructure.Tests.Integration

Checkout.Vault.CardStorage.Api.Tests.Acceptance

Checkout.Vault.CardStorage.Application.Tests.Unit

Checkout.Vault.CardStorage.Core.Tests.Unit

*Notice the tests are Unit, Integration and Acceptance. I’m going to assume you know what these are, but if not completely familiar then you can google them.

Integration:
Checkout.Vault.CardStorage.Infrastructure.Tests.Integration

Unit:
Checkout.Vault.CardStorage.Application.Tests.Unit

Checkout.Vault.CardStorage.Core.Tests.Unit

Acceptance:
Checkout.Vault.CardStorage.Api.Tests.Acceptance

*Recommended: write the acceptance tests in a stack which has rich debugging support for cadence, potentially a stack that is different to the implementation.

Pillars of Good Software Architecture:
Consider the following as usual: Scalability / Availability, Resiliency, Logging & Metrics, Automated Continuous Integration and Deployment. 

See It In A Demo Here:
If people are interested I’ve created a Vault Demo of a Simplified Vault using Clean Architecture - Note: This also includes CQRS, Eventual Consistency, Read Model Projections and paved the way for Domain Driven Design. But, it should be noted that the Clean Architecture part refers to the solution structure and foundations upon which the concepts mentioned build upon. 
View here: CQRS, Event Sourcing with Eventual Consistency in an Clean Architecture - Vault Demo - 2 Jul 2021 (send a message to request link).

Next Topics:
CQRS

Event Driven Architecture

Event Sourcing

Eventual Consistency

Domain Driven Design

Pillars of Good Software Architecture
