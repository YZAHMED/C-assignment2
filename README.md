# C# Assignment 2  

## 📌 Overview  
This assignment focuses on **ASP.NET Core Web API** development, documentation, and testing. It requires implementing API controllers, writing clear documentation, and testing using `cURL`. The assignment is worth **20%** of the final grade.  

## 🛠 Tasks  
- Implement **ASP.NET Core Web API Controllers** for given problems  
- Use **descriptive variable names** and method documentation (`<summary>` blocks)  
- Provide **evidence of testing** using `cURL`  

## 🔗 Useful Links  
- [Canadian Computing Competition (CCC)](https://cemc.uwaterloo.ca/resources/past-contests#ccc?grade=19&academic_year=All&contest_category=29)  
- [String.Split() Documentation](https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-8.0)  

## ⚠️ Submission Instructions  
1. Push your work to a **public GitHub repository**.  
2. Verify that all required files are included.  
3. Submit the **GitHub link** and a **PDF with cURL test results**.  

## 🖥️ Sample Code  
```csharp
[HttpPost("api/J1/Delivedroid")]
public IActionResult CalculateScore(int Collisions, int Deliveries)
{
    int score = (Deliveries * 50) - (Collisions * 10);
    if (Deliveries > Collisions) score += 500;
    return Ok(score);
}
```

Good luck! 🚀  
