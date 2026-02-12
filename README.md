# HelloWorldAPI

This is the simplest API possible! Run this project in Visual Studio, then use the following code to consume the API (in LINQPad, for example):

```
using System.Net.Http;

using var client = new HttpClient();
string json = await client.GetStringAsync("http://localhost:5093/api/hello");
Console.WriteLine(json);
```
