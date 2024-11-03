using System.ComponentModel.DataAnnotations;
using ManageEmployee.Dal.DbContexts;
using ManageEmployee.DataTransferObject.AreaModels;
using ManageEmployee.Entities.AreaEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManageEmployee.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AreaController:ControllerBase{
    readonly ApplicationDbContext dbContext;
    public AreaController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody]AreaDTO model){
        Area area = new Area();
        area.Code = model.Code;
        area.Name = model.Name;

        try{
            await dbContext.AddAsync(area);
            await dbContext.SaveChangesAsync();
        }
        catch{
            return StatusCode(500,"Loi");
        }
        return Created("",area);
    }

    [HttpPut]
    [Route("{Id:required:int}")] 
    public async Task<IActionResult> Edit([FromRoute][Required]int Id,[FromBody] AreaDTO model){
        var area = await dbContext.Areas.FirstOrDefaultAsync(a=>a.Id==Id);
        if(area == null){
            return NotFound("Khong tim thay area");
        }

        area.Code = model.Code;
        area.Name = model.Name;

        try{
            dbContext.Update(area);
            await dbContext.SaveChangesAsync();
        }
        catch{
            return StatusCode (500,"Loi");
        }
        return Ok(area);
    }

    [HttpDelete]
    [Route("{Id:required:int}")]
    public async Task<IActionResult> Delete([FromRoute][Required] int Id){
        var area = await dbContext.Areas.FirstOrDefaultAsync(a=>a.Id == Id);

        if(area != null){
            try{
                dbContext.Remove(area);
                await dbContext.SaveChangesAsync();
            }
            catch{
                return StatusCode(500,"Loi");
            }
        }

        return Ok();
    }
}