# GraphQL meets .Net6

## Additional useful libraries
GraphQL to EF & SQL Calls: [https://github.com/EntityGraphQL/EntityGraphQL](https://github.com/EntityGraphQL/EntityGraphQL)  


## GraphQL vs REST
[Explanation from IBM](https://www.youtube.com/watch?v=PTfZcN20fro)  
**REST**: CRUD based on resources. It provides complete set of operations over your data. But as a drawback in complex situations may send you over-fetched or under-fetched data.  
**GraphQL**: To fetch or mutate data using exact one request. Schema+resolver you created will take care of the rest. Good in complex data situations or in situations when you want to reduce the throughput because of over-fetching.  
  
**GraphQL** also does not dicrate patterns or project structure and could be introduced on top of already existing architecture.  

## General Information
![image](https://user-images.githubusercontent.com/4239376/230193846-1d5b6066-caa8-46ee-b597-33c74a339464.png)
![image](https://user-images.githubusercontent.com/4239376/230776847-2edb4868-8e51-467e-b9a8-d0c7ac6dcbe3.png)

![image](https://user-images.githubusercontent.com/4239376/229582245-a736c974-da88-4bd7-a4ac-b6fc4886bd86.png)

## Types & Mapping in .Net
![image](https://user-images.githubusercontent.com/4239376/230194495-cf1b6a64-8a86-45ec-bef6-0a274079e0c2.png)
![image](https://user-images.githubusercontent.com/4239376/230194777-4aa44db6-826a-42e5-a997-b2d8af3b2641.png)
![image](https://user-images.githubusercontent.com/4239376/230195410-b49ed8bf-f97a-46ca-b37c-70eebf2d7e1f.png)
![image](https://user-images.githubusercontent.com/4239376/230195915-daae35c3-08c6-4c69-af02-0d6fdc6d86cd.png)

## Working app primitives
#### Queries (2 options to write query):
![query](https://user-images.githubusercontent.com/4239376/230211775-c5fa92e9-66d2-4ebc-90c1-1ec54461e1f1.png)
![image](https://user-images.githubusercontent.com/4239376/230778518-958dfb5f-0334-4729-a426-2bbc5f61aea0.png)
#### Query relational data:
![image](https://user-images.githubusercontent.com/4239376/230792849-1b994267-b9b9-4553-a527-78d03578736e.png)
#### Mutations (in my example you need to define what you expect in output because I return back Course from Repository):
![mutation](https://user-images.githubusercontent.com/4239376/230778470-c1a5c4a1-e115-44d0-ae97-62f9a2e288c5.png)
![single update](https://user-images.githubusercontent.com/4239376/230780232-0e2214d2-19aa-4527-bc27-a2c583cdc50d.png)
![delete](https://user-images.githubusercontent.com/4239376/230783394-9f9a4f95-4827-4233-b3b9-2410591afd6e.png)
#### Mutations for relational data
![add course with reviews](https://user-images.githubusercontent.com/4239376/230793819-2dbe7a7c-7143-4735-9bc1-43726de39dc2.png)




