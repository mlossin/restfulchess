# restfulchess
RESTful Chess is a REST-API with HATEOAS to provide an chess board with its moving-possibilities.

It is meant to just implement HATEOAS as most RESTful APIs, especially in fat-client to rest api communication often dont provide it.

## Chess
The stateful application shall be a chess board. It provides all further step information after a request to the current state.

## Technical Information
.NET Version 6 LTS
Web Api using Asp.NET Core 6
Validation using FluentValidation
Unit Tests using MSTestv2
Dependeny Injection using MS DI

Architectural Pattern: Trying Composite Components

## HATEOAS
Hypermedia as the engine of application state (HATEOAS) is the last constraint to a resful api concerning richardsons maturity model.
It is not trivial to implement each response with a given state and further actions. It will give the following pros and cons:
   
+ API becomes self-discoverable and explorable
+ A client can use the links to implement its logic, it becomes much easier, and any changes that happen in the API structure are directly reflected onto the client
+ The server drives the application state and URL structure and not vice versa
+ The link relations can be used to point to developer documentation
+ Versioning through hyperlinks becomes easier
+ Reduced invalid state transaction calls
+ API is evolvable without breaking all the clients
- Hard to implement (server side)
- Harder to use (Clients dynamically use the links and cannot rely on a fix structure)?

## Sources
This is a custom implementation inspired by https://code-maze.com/hateoas-aspnet-core-web-api/