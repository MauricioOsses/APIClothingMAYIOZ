﻿using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.Repositories.InterfazRepository;
using Microsoft.EntityFrameworkCore;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected readonly ClothingDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public RepositoryBase(ClothingDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();

    public async Task<T?> GetById(int id) => await _dbSet.FindAsync(id);

    public async Task Add(T entity)
    {
        _dbSet.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task Delete(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
