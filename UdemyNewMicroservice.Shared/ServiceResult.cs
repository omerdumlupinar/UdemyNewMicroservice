using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using Refit;
using ProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace UdemyNewMicroservice.Shared
{
    public class ServiceResult
    {
        [JsonIgnore]
        public HttpStatusCode Status { get; set; }

        public ProblemDetails? Fail { get; set; }

        [JsonIgnore]
        public bool IsSuccess => Fail is null;

        [JsonIgnore]
        public bool IsFail => !IsSuccess;


        public static ServiceResult SuccessAsNoContent()
        {
            return new ServiceResult
            {
                Status = HttpStatusCode.NoContent
            };
        }

        public static ServiceResult ErrorAsNotFound()
        {
            return new ServiceResult
            {
                Status = HttpStatusCode.NotFound,
                Fail = new ProblemDetails
                {
                    Title = "Not Found",
                    Detail = "The recuested source was not found",
                }
            };
        }

        public static ServiceResult Error(ProblemDetails problemDetails, HttpStatusCode httpStatusCode)
        {
            return new ServiceResult
            {
                Fail = problemDetails,
                Status = httpStatusCode,
            };
        }

        public static ServiceResult Error(string title, string description, HttpStatusCode httpStatusCode)
        {
            return new ServiceResult
            {
                Status = httpStatusCode,
                Fail = new ProblemDetails()
                {
                    Title = title,
                    Detail = description,
                    Status = httpStatusCode.GetHashCode(),
                },
            };
        }

        public static ServiceResult Error(string title, HttpStatusCode httpStatusCode)
        {
            return new ServiceResult
            {
                Status = httpStatusCode,
                Fail = new ProblemDetails()
                {
                    Title = title,
                    Status = httpStatusCode.GetHashCode(),
                },
            };
        }


        public static ServiceResult ErrorFromProblemDetails(ApiException exception)
        {
            if (string.IsNullOrEmpty(exception.Content))
            {
                return new ServiceResult
                {
                    Fail = new ProblemDetails()
                    {
                        Title = exception.Message,
                    },
                    Status = exception.StatusCode,
                };

            }
            var problemDetails = JsonSerializer.Deserialize<ProblemDetails>(exception.Content, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            });

            return new ServiceResult
            {
                Fail = problemDetails,
                Status = exception.StatusCode,
            };
        }

        public static ServiceResult ErrorFromValidation(IDictionary<string, object> errors)
        {
            return new ServiceResult
            {
                Status = HttpStatusCode.BadRequest,
                Fail = new ProblemDetails()
                {
                    Title = "Validation errors occured",
                    Detail = "Plase check the errors proporty for more details",
                    Extensions = errors,
                    Status = HttpStatusCode.BadRequest.GetHashCode(),
                },
            };
        }
    }

    public class ServiceResult<T> : ServiceResult
    {
        public T? Data { get; set; }
        public string? UrlAsCreated { get; set; }

        public new static ServiceResult<T> SuccessAsOk(T data)
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.OK,
                Data = data
            };
        }

        public new static ServiceResult<T> SuccessAsCreated(T data, string url)
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.OK,
                Data = data,
                UrlAsCreated = url
            };
        }


        public new static ServiceResult<T> Error(ProblemDetails problemDetails, HttpStatusCode httpStatusCode)
        {
            return new ServiceResult<T>
            {
                Fail = problemDetails,
                Status = httpStatusCode,
            };
        }

        public new static ServiceResult<T> Error(string title, string description, HttpStatusCode httpStatusCode)
        {
            return new ServiceResult<T>
            {
                Status = httpStatusCode,
                Fail = new ProblemDetails()
                {
                    Title = title,
                    Detail = description,
                    Status = httpStatusCode.GetHashCode(),
                },
            };
        }

        public new static ServiceResult<T> Error(string title, HttpStatusCode httpStatusCode)
        {
            return new ServiceResult<T>
            {
                Status = httpStatusCode,
                Fail = new ProblemDetails()
                {
                    Title = title,
                    Status = httpStatusCode.GetHashCode(),
                },
            };
        }


        public new static ServiceResult<T> ErrorFromProblemDetails(ApiException exception)
        {
            if (string.IsNullOrEmpty(exception.Content))
            {
                return new ServiceResult<T>
                {
                    Fail = new ProblemDetails()
                    {
                        Title = exception.Message,
                    },
                    Status = exception.StatusCode,
                };

            }
            var problemDetails = JsonSerializer.Deserialize<ProblemDetails>(exception.Content, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            });

            return new ServiceResult<T>
            {
                Fail = problemDetails,
                Status = exception.StatusCode,
            };
        }

        public new static ServiceResult<T> ErrorFromValidation(IDictionary<string, object> errors)
        {
            return new ServiceResult<T>
            {
                Status = HttpStatusCode.BadRequest,
                Fail = new ProblemDetails()
                {
                    Title = "Validation errors occured",
                    Detail = "Plase check the errors proporty for more details",
                    Extensions = errors,
                    Status = HttpStatusCode.BadRequest.GetHashCode(),
                },
            };
        }
    }
}
