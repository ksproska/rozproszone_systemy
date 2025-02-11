﻿using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GrpcServer
{
    public class ShapesAnalyzerService : ShapesAnalyzer.ShapesAnalyzerBase
    {
        private readonly ILogger<ShapesAnalyzerService> _logger;
        public ShapesAnalyzerService(ILogger<ShapesAnalyzerService> logger)
        {
            _logger = logger;
        }

        public static void PrintRunningName(string name)
        {
            Console.Write("\nMethod ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(name);
            Console.ResetColor();
            Console.WriteLine(" is running.");
        }

        public override Task<IsTriangle> IsTriangleOk(TriangleSides request, ServerCallContext context)
        {
            PrintRunningName(MethodBase.GetCurrentMethod().Name);
            bool message = false;
            string triangle = "non-traingle";
            double longest;
            double one = 0;
            double two = 0;
         
            longest = Math.Max(Math.Max(request.A, request.B), request.C);
            if (longest == request.A)
            {
                one = request.B;
                two = request.C;
            }
            else if (longest == request.B)
            {
                one = request.A;
                two = request.C;
            }
            else if (longest == request.C)
            {
                one = request.A;
                two = request.B;
            }
                
            if (one + two > longest && request.A > 0 && request.B > 0 && request.C > 0)
            {
                message = true;
                if (one * one + two * two == longest * longest)
                {
                triangle = "right";
                }
                else if (one * one + two * two < longest * longest)
                {
                    triangle = "obtuse";
                }
                else if (one * one + two * two > longest * longest)
                {
                    triangle = "acute";
                }
            } 
            
            return Task.FromResult(new IsTriangle
            {
                Message = message,
                Triangle = triangle
            });
        }

        public override Task<Perimeter> GetTrianglePerimeter(TriangleSides request, ServerCallContext context)
        {
            PrintRunningName(MethodBase.GetCurrentMethod().Name);
            double perimeter = request.A + request.B + request.C;
            return Task.FromResult(new Perimeter
            {
                P = perimeter
            });
        }

        public override Task<Surface> GetTriangleSurface(TriangleSides request, ServerCallContext context)
        {
            PrintRunningName(MethodBase.GetCurrentMethod().Name);
            double p = (request.A + request.B + request.C) / 2;
            double multiplied = p * Math.Abs(p - request.A) * Math.Abs(p - request.B) * Math.Abs(p - request.C);
            double size = Math.Sqrt(multiplied);
            return Task.FromResult(new Surface
            {
                Size = size
            });
        }

        public override Task<IsRightAngle> IsTriangleRightAngle(TriangleSides request, ServerCallContext context)
        {
            PrintRunningName(MethodBase.GetCurrentMethod().Name);
            bool message = false;
            if (request.A * request.A == request.B * request.B + request.C * request.C || request.B * request.B == request.A * request.A + request.C * request.C || request.C * request.C == request.A * request.A + request.B * request.B)
            {
                message = true;
            }
            return Task.FromResult(new IsRightAngle
            {
                Message = message
            });
        }

        public override Task<IsIsosceles> IsTriangleIsosceles(TriangleSides request, ServerCallContext context)
        {
            PrintRunningName(MethodBase.GetCurrentMethod().Name);
            bool message = false;
            if (request.A == request.B || request.B == request.C || request.C == request.A)
            {
                message = true;
            }
            return Task.FromResult(new IsIsosceles
            {
                Message = message
            });
        }
    }
}
