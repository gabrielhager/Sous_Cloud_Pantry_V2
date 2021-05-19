# Sous Cloud Pantry Final Review 
## 🌀 The App is now live! Check it out [here](https://souspantry.azurewebsites.net) 🌀

#### 1. Describe project experience including each phase of the SDLC and the project artifacts (design documents, requirements trace, test reports...)

In the begining I set out to create this to solve an actual problem that my family was facing on a weekly basis. We could never decide what to cook for dinner, but we always end up 
picking from the same 10 or so dishes. Due to this repetition, I knew that the process could be streamlined. In the beginning I had grand ideas of scheduling meals and automated emails
reminding users what meals they have planned each night but this dream was a bit more than I could handle during the scope of this course. I knew the overall project began pretty small 
in scope, so the fact that I was not able to meet every requirement was a bit dissapointing, however I am happy with where the project is at today. 

The look and feel of the App is very much what I envisioned, however when I initially created my databases, I had no idea what I was doing. For example, in my initial database creation
I planned for 6 tables, my current project only uses 3 (not including the tables that come out of the box with Microsoft Identity). Over the course of the project I completely restarted
and built a new solution in Visual Studio due mainly to implementation confusions with Microsoft Identity and removing/editing my data tables and fields. Most of my testing was trial
and error based and I did not create any test classes which was really a missed opportunity on my part to get hands on experience in TDD. It is nice to have a project under my belt
and I will take this experience and build upon it in my future development career.

#### 2. Code and Architecture Walk-Through

#### 3. Product Demonstration

#### 5. Lessons Learned:
- What did you do right?

I knew from the begining that I needed to pick a project small in scope, and I think initially I did not have too unrealistic expectations. Additionally, I planned to have a very 
simple and clean UI and I am happy with the final result. Bootstrap is a life saver and I love it.

- What did you do wrong?

I did not spend the time and attention needed on my database tables from the get go. I did not fully flesh out the table relationships fully, and I did not even take into account
the Identity tables and how they would interfere/overlap with my personally generated users table. Because of this I ended up using very bad practices in order to display my data
and have learned to pay much closer attention to normal form.

- Where were you lucky?

I got lucky in that while Microsoft Identity broke my database schema, it also provided a solution that allowed me to salvage a few of my tables producing a close to inteneded result.
By adding an username field to each data table I was able to reference the current logged in user (User.Identity.Name) in order to use LINQ Query Syntax magic. (I know this is bad form
but I got lucky!)

- What would you change / what do you know now that you wish you knew "then"?

I wish I knew about Identity sooner (this would have saved me a week) and I also wish I would have had a better grasp on my database structure. Additionally, I did not know how much
javascript knowledge I was going to need to implement some of my desired features that got scrapped in order to have planned better from the get-go.

-What is next?

I do still have a desire to work on this project in some capacity. I might use the lessons learned as a template for creating an app in Swift for iOS or if I make the switch to Angular
this project would be good to learn other technologies in. I also would like to experiment with creating an Amazon Alexa skill (once the step-by-step recipes are implemented) to play
around with APIs.

👨‍🍳 Bon Appétit!

