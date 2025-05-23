﻿using System;
using CloudinaryDotNet.Actions;

namespace RunGroup.Interfaces
{
	public interface IPhotoService
	{
		Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

		Task<DeletionResult> DeletePhotoAsync(string publicId);

    }
}

