using Microsoft.EntityFrameworkCore;

public class RecruitCatBowlingyContext(DbContextOptions<RecruitCatBowlingyContext> options) : DbContext(options)
{
    public DbSet<RecruitCatBowlingy.Models.Candidate> Candidate { get; set; } = default!;
    public DbSet<RecruitCatBowlingy.Models.Company> Company { get; set; } = default!;
    public DbSet<RecruitCatBowlingy.Models.Industry> Industry { get; set; } = default!;
    public DbSet<RecruitCatBowlingy.Models.JobTitle> JobTitle { get; set; } = default!;
}
