# InfusingNETWithAI
As promised on the talk, here are the slides and code for the OST event ".NET and the future", talk is «Infusing AI into your .NET Application with Semantic Kernel».

Thanks again to Manuel Bauer and OST (https://www.ost.ch/) for inviting me to this prestigious University, it was an absolute pleasure and honor. Thank you all!!

Event link:
https://www.ost.ch/de/event/net-and-the-future

Some notes:
- As mentioned, the code is using Semantic Kernel 1.5.1, this is a few months old but almost all is relevant and working.
- Note that the agents have a new model, but I believe the "old one" is still relevant, maybe needing a few adjustments, but the main concept is the same.
- The "New Agent Model" enables a group chat which is inspired/inherited from the AutoGen project, very cool so go try it out ;)
- Also be aware it is still experimental, so might undergo breaking changes ;)

The demos included, each on its own containing class, issolated so can be moved and ported individualy in an easy way, are:
- BasicSK - simple SK showing configuration, kernel usage, plugin usage, auto function calling and prompt invoking. All in 39 lines of code inc usings (can be optimized)
- BasicSKChat - Similar but chat driven (conversation)
- Personas - A simple Agent example, but a fun one. Look into it and see... Banana!!
- CriticWorkflow - A 2 way chat showing up how to implement a Critic workflow so you don't have to be on the other side of the chat correcting - AI can do it for you ;)

Hope you liked it and you can follow me on LinkedIn, Twitter if you think my ideas resonate with you:
- https://www.linkedin.com/in/joslat/
- https://x.com/joslat
- https://github.com/joslat/


Also, join the community: 
- https://www.linkedin.com/company/dotnet-zurich/
- https://www.meetup.com/dotnet-zurich/

And if you read this with time, join the Global AI Zurich Launch:
- meetup.com/global-ai-zurich/events/302312863/

If you like to know more on the topics presented, you can check my "at the moment" two courses on AI on LinkedIn:
- linkedin.com/learning/semantic-kernel-in-action-fundamentals/
- linkedin.com/learning/azure-ai-engineer-associate-ai-102-cert-prep-exam-tips/


Have fun & keep coding,
José

