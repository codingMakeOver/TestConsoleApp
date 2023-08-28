using System.Net.Sockets;

for (int i = 10000; i > 0; i--)
{
    Thread.Sleep(500);
    Console.WriteLine($"{i} -- Hello, World!");
}

//  docker image build --no-cache -t dotnet6consoleapp:v2 .
//docker run --rm --platform=windows --env=DOTNET_RUNNING_IN_CONTAINER=true -d --name dotnetcontainerconsoleapp doetnet6consoleapp:v2
