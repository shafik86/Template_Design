using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Template_Design.shared;

namespace Template_Design.Models.Services
{
    public class TemplateService : ITemplateService
    {
        public TemplateService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public AppDbContext _appDbContext { get; }

        public async Task<Template> AddTemplate(Template newTemplate)
        {
            var result = await _appDbContext.Templates.AddAsync(newTemplate);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteTemplate(int templateId)
        {
            var result = await _appDbContext.Templates.FirstOrDefaultAsync(e => e.Id == templateId);
            if (result != null) {
                _appDbContext.Templates.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Template> GetTemplateById(int templateId)
        {
            if (templateId != 0)
            {
                var result = await _appDbContext.Templates.FirstOrDefaultAsync(e => e.Id == templateId);
                if (result != null)
                {
                    return result;
                }
            }

            return null;

        }

        public async Task<IEnumerable<Template>> GetTemplates()
        {
            return await _appDbContext.Templates.ToListAsync(); 
        }

        public async Task<Template> UpdateTemplate(Template updateTemplate)
        {
            var result = await _appDbContext.Templates.FirstOrDefaultAsync(e => e.Id == updateTemplate.Id);
            if (result != null)
            {
                result.Name = updateTemplate.Name;
                result.Description = updateTemplate.Description;
                result.Thumb = updateTemplate.Thumb;
                result.PbiUrl = updateTemplate.PbiUrl;

                await _appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
