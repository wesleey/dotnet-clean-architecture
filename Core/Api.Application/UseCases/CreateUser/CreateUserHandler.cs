using Api.Domain.Entities;
using Api.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace Api.Application.UseCases.CreateUser;

public class CreateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
: IRequestHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IUserRepository _repository = userRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        var existingUser = await _repository.Get(request.Email, cancellationToken);

        if (existingUser is not null)
            throw new ArgumentException("Email already registered.");

        _repository.Create(user);
        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateUserResponse>(user);
    }
}
