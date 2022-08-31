using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactAPI.demo.Data;
using ReactAPI.demo.Data.Entities;
 
namespace ReactAPI.demo.Controllers;
 
[ApiController]
[Route("[controller]")]
public class SuperVillainController : ControllerBase
{
    private readonly ReactJSDemoYTContext _reactContext;
    public SuperVillainController(ReactJSDemoYTContext reactContext)
    {
        _reactContext = reactContext;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var villains = await _reactContext.SuperVillain.ToListAsync();
	    return Ok(villains);
    }

    [HttpPost]
    public async Task<IActionResult> Post(SuperVillain newSuperVillain)
    {
        _reactContext.SuperVillain.Add(newSuperVillain);
        await _reactContext.SaveChangesAsync();
        return Ok(newSuperVillain);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var villainById = await _reactContext
        .SuperVillain.Where(_ => _.Id == id)
        .FirstOrDefaultAsync();
        return Ok(villainById);
    }

    [HttpPut]
    public async Task<IActionResult> Put(SuperVillain villainToUpdate)
    {
        _reactContext.SuperVillain.Update(villainToUpdate);
        await _reactContext.SaveChangesAsync();
        return Ok(villainToUpdate);
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var villainToDelete = await _reactContext.SuperVillain.FindAsync(id);
        if (villainToDelete == null)
        {
            return NotFound();
        }
        _reactContext.SuperVillain.Remove(villainToDelete);
        await _reactContext.SaveChangesAsync();
        return Ok();
    }

    //Categories

    [HttpGet]
    [Route("category")]
    public async Task<IActionResult> GetCategory()
    {
        var category = await _reactContext.Category.ToListAsync();
	    return Ok(category);
    }

    [HttpPost]
    [Route("addCategory")]
    public async Task<IActionResult> PostCategory(Category newSuperVillain)
    {
        _reactContext.Category.Add(newSuperVillain);
        await _reactContext.SaveChangesAsync();
        return Ok(newSuperVillain);
    }

    [HttpGet]
    [Route("category/{id:int}")]
    public async Task<IActionResult> GetCategory(int id)
    {
        var villainById = await _reactContext
        .Category.Where(_ => _.Id == id)
        .FirstOrDefaultAsync();
        return Ok(villainById);
    }

    [HttpPut]
    [Route("updateCategory")]
    public async Task<IActionResult> PutCategory(Category villainToUpdate)
    {
        _reactContext.Category.Update(villainToUpdate);
        await _reactContext.SaveChangesAsync();
        return Ok(villainToUpdate);
    }

    [HttpDelete]
    [Route("deleteCategory/{id:int}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var villainToDelete = await _reactContext.Category.FindAsync(id);
        if (villainToDelete == null)
        {
            return NotFound();
        }
        _reactContext.Category.Remove(villainToDelete);
        await _reactContext.SaveChangesAsync();
        return Ok();
    }

    //Manufacturers
    [HttpGet]
    [Route("manufacturer")]
    public async Task<IActionResult> GetManufacturer()
    {
        var category = await _reactContext.Manufacturer.ToListAsync();
	    return Ok(category);
    }

    [HttpPost]
    [Route("addManufacturer")]
    public async Task<IActionResult> PostManufacturer(Manufacturer newSuperVillain)
    {
        _reactContext.Manufacturer.Add(newSuperVillain);
        await _reactContext.SaveChangesAsync();
        return Ok(newSuperVillain);
    }

    [HttpGet]
    [Route("manufacturer/{id:int}")]
    public async Task<IActionResult> GetManufacturer(int id)
    {
        var villainById = await _reactContext
        .Manufacturer.Where(_ => _.Id == id)
        .FirstOrDefaultAsync();
        return Ok(villainById);
    }

    [HttpPut]
    [Route("updateManufacturer")]
    public async Task<IActionResult> PutManufacturer(Manufacturer villainToUpdate)
    {
        _reactContext.Manufacturer.Update(villainToUpdate);
        await _reactContext.SaveChangesAsync();
        return Ok(villainToUpdate);
    }

    [HttpDelete]
    [Route("deleteManufacturer/{id:int}")]
    public async Task<IActionResult> DeleteManufacturer(int id)
    {
        var villainToDelete = await _reactContext.Manufacturer.FindAsync(id);
        if (villainToDelete == null)
        {
            return NotFound();
        }
        _reactContext.Manufacturer.Remove(villainToDelete);
        await _reactContext.SaveChangesAsync();
        return Ok();
    }

    //Medicine
    [HttpGet]
    [Route("medicine")]
    public async Task<IActionResult> GetMedicine()
    {
        var category = await _reactContext.Medicine.ToListAsync();
	    return Ok(category);
    }

    [HttpPost]
    [Route("addMedicine")]
    public async Task<IActionResult> PostMedicine(Medicine newSuperVillain)
    {
        _reactContext.Medicine.Add(newSuperVillain);
        await _reactContext.SaveChangesAsync();
        return Ok(newSuperVillain);
    }

    [HttpGet]
    [Route("medicine/{id:int}")]
    public async Task<IActionResult> GetMedicine(int id)
    {
        var villainById = await _reactContext
        .Medicine.Where(_ => _.Id == id)
        .FirstOrDefaultAsync();
        return Ok(villainById);
    }

    [HttpPut]
    [Route("updateMedicine")]
    public async Task<IActionResult> PutMedicine(Medicine villainToUpdate)
    {
        _reactContext.Medicine.Update(villainToUpdate);
        await _reactContext.SaveChangesAsync();
        return Ok(villainToUpdate);
    }

    [HttpDelete]
    [Route("deleteMedicine/{id:int}")]
    public async Task<IActionResult> DeleteMedicine(int id)
    {
        var villainToDelete = await _reactContext.Medicine.FindAsync(id);
        if (villainToDelete == null)
        {
            return NotFound();
        }
        _reactContext.Medicine.Remove(villainToDelete);
        await _reactContext.SaveChangesAsync();
        return Ok();
    }

    //Invoice
    [HttpGet]
    [Route("invoice")]
    public async Task<IActionResult> GetInvoice()
    {
        var category = await _reactContext.Invoice.ToListAsync();
	    return Ok(category);
    }

    [HttpPost]
    [Route("addInvoice")]
    public async Task<IActionResult> PostInvoice(Invoice newSuperVillain)
    {
        _reactContext.Invoice.Add(newSuperVillain);
        await _reactContext.SaveChangesAsync();
        return Ok(newSuperVillain);
    }

    [HttpGet]
    [Route("invoice/{id:int}")]
    public async Task<IActionResult> GetInvoice(int id)
    {
        var villainById = await _reactContext
        .Invoice.Where(_ => _.Id == id)
        .FirstOrDefaultAsync();
        return Ok(villainById);
    }

    [HttpPut]
    [Route("updateInvoice")]
    public async Task<IActionResult> PutInvoice(Invoice villainToUpdate)
    {
        _reactContext.Invoice.Update(villainToUpdate);
        await _reactContext.SaveChangesAsync();
        return Ok(villainToUpdate);
    }

    [HttpDelete]
    [Route("deleteInvoice/{id:int}")]
    public async Task<IActionResult> DeleteInvoice(int id)
    {
        var villainToDelete = await _reactContext.Invoice.FindAsync(id);
        if (villainToDelete == null)
        {
            return NotFound();
        }
        _reactContext.Invoice.Remove(villainToDelete);
        await _reactContext.SaveChangesAsync();
        return Ok();
    }
}