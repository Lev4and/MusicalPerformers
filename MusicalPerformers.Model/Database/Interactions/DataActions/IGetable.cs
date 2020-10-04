﻿using System.Data;

namespace MusicalPerformers.Model.Database.Interactions.DataActions
{
    /// <summary>
    /// Интерфейс, описывающий запросы к базе данных, необходимые для получения данных.
    /// </summary>
    public interface IGetable
    {
        /// <summary>
        /// Получение идентификационного номера должности по указанному названию.
        /// </summary>
        /// <param name="roleName">Название должности.</param>
        /// <returns>Возвращает идентификационный номер должности.</returns>
        int GetRoleId(string roleName);

        /// <summary>
        /// Получение всех должностей.
        /// </summary>
        /// <returns>Возвращает все существующие должности, находящиеся в базе данных.</returns>
        DataTable GetRoles();

        /// <summary>
        /// Получение пользовательской информации.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        /// <returns>Информация о пользователе.</returns>
        DataTable GetUserInformation(int userId);

        /// <summary>
        /// Получение пользовательской информации.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <returns>Информация о пользователе.</returns>
        DataTable GetUserInformation(string login);
    }
}
