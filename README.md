# PublicWebQA

Please add directory location for chromedrive.exe in BasePage.cs (StartBrowser();)

De minimis  
Open Browser (before test) 
Close Browser (after test) 
 
 Precondition  
Go to https://www.progress.com/customers 
Assert that the page is correctly loaded 
URL contains Customers  
Return document.readyState 
Class PRGS-Nav-title is presented on page and contains text Customers 
 
1. Scenario Success story     
Go to https://www.progress.com/customers/doctor-shterev-hospital 
Assert that the page is correctly loaded 
URL contains Shterev Hospital  
Return document.readyState 
Assert Story structure  
Challenge 
Solution 
 Result 
  
2. Scenario Filtration 
Go to https://www.progress.com/customers 
Assert that the page is correctly loaded 
 Select Industry /Product / Solution  
 Assert that selected filtration is working as expected 
   
3.  Scenario Navigator  
Go to https://www.progress.com/services/consulting 
Assert that the page is correctly loaded 
URL contains Consulting  
Page Title contains Text Consulting 
  
 4. Scenario Slider dot (https://www.progress.com/)  - NOT FINISHED
Go to https://www.progress.com/services/consulting 
Assert that the page is correctly loaded 
Check that arrows are active and functional  
Slider-dot active 
Left arrow  - for first active, second active and third active div 
Right arrow - for first active, second active and third active div 
  
5. Sticky navigation test  - NOT DONE
	//div[@class = 'Dropdown Dropdown--Select is-open']//li 
     
    

