# ECommerceProject
Project is written in C# and JavaScript (for scripts) with use of ASP.NET Razor for views. MVC is main design pattern. 
Solution is divided into two projects - ECommerce.Logic - keeping all Objects, Models, ModelBuilders, Commanders, and DataSource managment.
The other project is ECommerce.Website - containing Controllers, Views and files including styles, scripts etc.
# Project logic
Project flow is simple - controllers call for builders, that build models, which are sent to views, where data is presented to user.
# Database 
For project that has to store only products for our website, I found creating database as a little overkill, and i decided to use simple CSV to load data at the website start.
It's not solution I would prefer in my business, but for little project I found it good enough.
# Possibilites
At the beggining user lands on index page of store - the list of all available prodcuts that he can purchase. He can manage to do that by clicking on image, to see more details about product, and simply by pressing + or - button managing its quantity in cart.
When user is done, he can go to cart page, where he can manually change his previous preferences, and when he is ready, click purchase, and be transferred to payment page.
# Payment
Unfortunatelly, I did not manage to implement payment provider. I tried with PayU, but I couldn't register there becouse of my "invalid" mobile number. (Standard 9-digit phone number, their page must be broken or america-only).

As my second choice I picked Przelewy24, where I was amazed by simplicity of its documentation, and I've quickly implemented it in my project. The only catch was that you have to own company-registered account, to use sandbox account. In my case, where I don't own any company and I did not want to deceive by registering not existing company, I gave up. Although rules are very simple - you need only to send post on url, with specified MerchantKey, MerchantSalt (these 2 I was missing), Price and Title. And thats it - provider does everyting for you, and returns to page you tell him to.

So overall I did simple page, where you only type in your account number, name, surname and CCV. 
