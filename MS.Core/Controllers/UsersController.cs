using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MS.Core.Models;
using MS.Core.ViewModels;

namespace MS.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _appDbContext;

        public UsersController(UserManager<User> userManager, AppDbContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
        }
        

        [HttpGet]
        public IActionResult GetByDepartment(string department)
        {
            var res = _userManager.Users.Select(x=>x.Department.Name == department);
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult> Statistics(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
               if (user != null) {
                foreach (var task in user.Jobs.TakeWhile(x=>x.State == State.Done))
                {
                    if (task.Complexity == 1)
                    {
                        user.Rating += 1;
                    }
                    else if (task.Complexity == 2)
                    {
                        user.Rating += 2;
                    }
                    else if (task.Complexity == 3)
                    {
                        user.Rating += 3;
                    }
                }
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var res = _userManager.Users.ToList();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest("500");
        }
        [HttpGet("{email}")]
        public async Task<ActionResult<User>> Index(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest(null);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            String errors = "";
            if (ModelState.IsValid)
            {
                User user = new User {
                    Id = Guid.NewGuid(),
                    Email = model.Email,
                    UserName = model.Email,
                    BirthDate = model.BirthDate,
                    Department = await _appDbContext.Departments.FindAsync(model.Department),
                    AccessModifier = model.AccessModifier,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    SecondName = model.SecondName,
                    Sex = model.Sex,
                    Wage = model.Wage,
                    PhoneNumber = model.Telephone,
                    Position = model.Position,
                    CreatedDate = DateTime.Now,
                    Rating = model.Rating
            };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        errors += error.Description + '\n';
                    }
                }
            }
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserViewModel model)
        {
            String errors = "";
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.BirthDate = model.BirthDate;
                    user.Department = await _appDbContext.Departments.FindAsync(model.Department);
                    user.AccessModifier = model.AccessModifier;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.SecondName = model.SecondName;
                    user.Sex = model.Sex;
                    user.Wage = model.Wage;
                    user.PhoneNumber = model.Telephone;
                    user.Position = model.Position;
                    user.Rating = model.Rating;

                       var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return Ok();
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            errors+= error.Description+'\n';
                        }
                    }
                }
            }
            return BadRequest(errors);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return Ok();
        }
    }
}
