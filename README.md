# Unity Engine TDD Template

This template can be used as reference to organize and setup unit testing inside you Unity project, to use it with Test Driven Development coding flow. It's divided into few solutions with two categories ***Gameplay*** and ***ThidrParty***. 

This approach has few advantages like faster code reload and recompiling but with flaw of mantianing and spliting the new imported code. It's all to you what you will choose. Gameplay has reference to ThirdParty solution for usage of ThirdParty code. 

Unity version used for a project template is : ``2202.3.12f1 LTS`` but it could work for any version above ``2019`` at least I think so. If not let me know if I can help.

## Project code structure

I will not write about advantages of this approach but I keep in mind that for some reasons you could have all your tests also in on Tests assembly. If it does work for you it's okay. I like to keep things seperated for sake of clarity and context. In this specific reason I split up each ``coding`` project in following manner:

- ``Gameplay`` - solution - It's a place where all logic connected to your game should be put. I bet you would like to add there to assembly a third party reference, so you can use code which is external one.
- ``ThirdParty`` solution - It's a place where you have some imported scripts or simply some code that should be independent and you don't want mess with. You can also implement it as you owns library and simply put reference to other libraries if needed.

And for each of above there is seperated:
- ``Tests`` solution - which contains all test scripts, which can be executed via editor 
- ``Tests.PlayMode`` - solution it's contains all code which has to be used in PlayMode 


Tests can be run via Test Runner for each of the solutions, but remember to maintain your code via folders and namespaces. I found hard to maintain and remember context of the test if they are not splited by category. It can be overwhelming when you can above one hundred classes in one namespace. In case you need example please check ``Gameplay.Tests``. 

For base usage of Moq lib please check ``ThirdParty.Tests``. And be sure to take a look at ``ThridPartyBehaviour`` class. I tried to comment some coding structure I follow and I myself consider as a good practice to follow. 

That's it and remember to:
**Enjoy your game dev journey!**





