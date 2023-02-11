// Initialize a stress test with a specified url
var stressTest = new StressTest("http://myhost.azurewebsites.net/"),

// Set the number of requests to send
stressTest.SetNumberOfRequests(1000);

// Set the request rate (Hz)
stressTest.SetRequestRate(50); 

// Run the stress test
stressTest.Run();
