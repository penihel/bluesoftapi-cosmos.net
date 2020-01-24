# bluesoftapi-cosmos.net
C# client implementation to API http://cosmos.bluesoft.io/api

> This project was initiated by Brazilians, and there is all the documentation in Portuguese for this API (http://cosmos.bluesoft.com.br/api). But the official language of the project will always be English to facilitate the spread of knowledge outside Brazil.

## API - Overview
The main objective of this API is to search for product information by barcode GTIN / EAN.

##How to use
###### Registration
+ Register here http://cosmos.bluesoft.io/api
+ Get your Token

###### Installation
+ Install the nuget package
```
Install-Package bluesoftapi-cosmos.net
```

###### Use
+ Import `Bluesoft.Cosmos` namespace
```c#
  using Bluesoft.Cosmos;
```
+ Create a instance of `CosmosClient` class passing your Token and endpoint

```c#
  string myToken = "....";
  CosmosClient client = new CosmosClient(CosmosEndpoint.BR, myToken);
```
+ Call a API operation
```c#
  string gtinBarCode = "....";
  var product = await client.GetProductByBarCodeAsync(gtinBarCode);
  
  

  Console.WriteLine(product.Description);
  Console.WriteLine(product.Price);
```

